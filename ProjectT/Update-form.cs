using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace ProjectT
{
    public partial class UpdateForm : Form
    {

        private int HEIGHT = 240;
        private int WIDTH = 240;

        // Determines boundary of brightness while turning grayscale image to binary (black-white) image
        private int THRESHOLD = 5;

        // Erosion to remove noise (reduce white pixel zones)
        private int ERODE_ITERATIONS = 3;

        // Dilation to enhance erosion survivors (enlarge white pixel zones)
        private int DILATE_ITERATIONS = 3;

        // Containers for images demonstrating different phases of frame processing 
        private static Mat rawFrame = new Mat();           // Frame as obtained from video
        private static Mat backgroundFrame = new Mat();    // Frame used as base for change detection
        private static Mat diffFrame = new Mat();          // Image showing differences between background 
                                                           // and raw frame
        private static Mat grayscaleDiffFrame = new Mat(); // Image showing differences in 8-bit color depth
        private static Mat binaryDiffFrame = new Mat();    // Image showing changed areas in white and 
                                                           // unchanged in black
        private static Mat denoisedDiffFrame = new Mat();  // Image with irrelevant changes removed 
                                                           // with opening operation
        private static Mat finalFrame = new Mat();         // Video frame with detected object marked
        private static Mat resizedImage = new Mat();
        

        private static MCvScalar drawingColor = new Bgr(Color.Red).MCvScalar;
    

        public UpdateForm()
        {
            InitializeComponent();

            hScrollBarDilation.Value = DILATE_ITERATIONS;
            hScrollBarErosion.Value = ERODE_ITERATIONS;
            hScrollBarThreshold.Value = THRESHOLD;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = TrainForm.TRAINING_PATH;
            if(DialogResult.OK == dialog.ShowDialog())
            {
                
                Image<Bgr, Byte> image = new Image<Bgr, byte>(dialog.FileName);
                
                Mat originalImage = new Mat(dialog.FileName, ImreadModes.Color);
                

                //if (originalImage.Height < originalImage.Width)
                //{
                //    WIDTH = 320;
                //    HEIGHT = 240;
                //}

                CvInvoke.Resize(originalImage, resizedImage, new Size(WIDTH, HEIGHT), 0, 0);

                pictureBoxOriginal.Image = resizedImage.Bitmap;

                                
                Mat[] splitImage = resizedImage.Split();
                Mat whiteChannel = new Mat();
                Mat greenChannel = splitImage[1];
                //Image<Bgr, Byte> img1 = new Image<Bgr, Byte>(resizedImage.Height, resizedImage.Width, new Bgr(0, 0, 0));

                //CvInvoke.Merge(new VectorOfMat(img1.Mat, greenChannel, img1.Mat), resizedImage);

                preprocess();
            }
        }

        private void preprocess()
        {
            ProcessFrame(resizedImage, THRESHOLD, ERODE_ITERATIONS, DILATE_ITERATIONS);

            pictureBoxBinary.Image = binaryDiffFrame.Bitmap;
            pictureBoxDenoised.Image = denoisedDiffFrame.Bitmap;
            pictureBoxGrayscale.Image = grayscaleDiffFrame.Bitmap;
            pictureBoxFinalResult.Image = finalFrame.Bitmap;
        }

        private static void ProcessFrame(Mat backgroundFrame, int threshold, int erodeIterations, int dilateIterations)
        {
            // Find difference between background (first) frame and current frame
            // CvInvoke.AbsDiff(backgroundFrame, rawFrame, diffFrame);

            diffFrame = backgroundFrame;
            rawFrame = backgroundFrame;

            // Apply binary threshold to grayscale image (white pixel will mark difference)
            CvInvoke.CvtColor(diffFrame, grayscaleDiffFrame, ColorConversion.Bgr2Gray);
            CvInvoke.Threshold(grayscaleDiffFrame, binaryDiffFrame, threshold, 255, ThresholdType.Binary);

            // Remove noise with opening operation (erosion followed by dilation)
            CvInvoke.Erode(binaryDiffFrame, denoisedDiffFrame, null,
                     new Point(-1, -1), erodeIterations, BorderType.Default, new MCvScalar(1));
            CvInvoke.Dilate(denoisedDiffFrame, denoisedDiffFrame, null,
                     new Point(-1, -1), dilateIterations, BorderType.Default, new MCvScalar(1));

            rawFrame.CopyTo(finalFrame);
            DetectObject(denoisedDiffFrame, finalFrame);
        }

        private static void DetectObject(Mat detectionFrame, Mat displayFrame)
        {
            using (VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint())
            {
                // Build list of contours
                CvInvoke.FindContours(detectionFrame, contours, null,
                                      RetrType.List, ChainApproxMethod.ChainApproxSimple);

                // Selecting largest contour
                if (contours.Size > 0)
                {
                    double maxArea = 0;
                    int chosen = 0;
                    for (int i = 0; i < contours.Size; i++)
                    {
                        VectorOfPoint contour = contours[i];

                        double area = CvInvoke.ContourArea(contour);
                        if (area > maxArea)
                        {
                            maxArea = area;
                            chosen = i;
                        }
                    }

                    // Draw on a frame
                    MarkDetectedObject(displayFrame, contours[chosen], maxArea);
                }
            }
        }

        private static void MarkDetectedObject(Mat frame, VectorOfPoint contour, double area)
        {
            // Getting minimal rectangle which contains the contour
            Rectangle box = CvInvoke.BoundingRectangle(contour);

            // Drawing contour and box around it
            CvInvoke.Polylines(frame, contour, true, drawingColor);
            CvInvoke.Rectangle(frame, box, drawingColor);

            // Write information next to marked object
            Point center = new Point(box.X + box.Width / 2, box.Y + box.Height / 2);

            var info = new string[] {
                $"Area: {area}",
                $"Position: {center.X}, {center.Y}"
            };

            WriteMultilineText(frame, info, new Point(box.Right + 5, center.Y));
        }

        private static void WriteMultilineText(Mat frame, string[] lines, Point origin)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                int y = i * 10 + origin.Y; // Moving down on each line
                CvInvoke.PutText(frame, lines[i], new Point(origin.X, y),
                                 FontFace.HersheyPlain, 0.8, drawingColor);
            }
        }

        private static void ShowWindowsWithImageProcessingStages()
        {
            CvInvoke.Imshow("RawFrameWindowName", rawFrame);
            CvInvoke.Imshow("GrayscaleDiffFrameWindowName", grayscaleDiffFrame);
            CvInvoke.Imshow("BinaryDiffFrameWindowName", binaryDiffFrame);
            CvInvoke.Imshow("DenoisedDiffFrameWindowName", denoisedDiffFrame);
            CvInvoke.Imshow("FinalFrameWindowName", finalFrame);
        }

        private void hScrollBarErosion_Scroll(object sender, ScrollEventArgs e)
        {
            DILATE_ITERATIONS = hScrollBarDilation.Value;
            ERODE_ITERATIONS = hScrollBarErosion.Value;
            THRESHOLD = hScrollBarThreshold.Value;

            preprocess();
        }

        private void hScrollBarDilation_Scroll(object sender, ScrollEventArgs e)
        {
            DILATE_ITERATIONS = hScrollBarDilation.Value;
            ERODE_ITERATIONS = hScrollBarErosion.Value;
            THRESHOLD = hScrollBarThreshold.Value;

            preprocess();
        }

        private void hScrollBarThreshold_Scroll(object sender, ScrollEventArgs e)
        {
            DILATE_ITERATIONS = hScrollBarDilation.Value;
            ERODE_ITERATIONS = hScrollBarErosion.Value;
            THRESHOLD = hScrollBarThreshold.Value;

            preprocess();
        }
    }
}
