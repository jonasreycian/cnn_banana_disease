using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV.Dnn;
using Emgu.CV.ML;

namespace ProjectT
{
    public partial class TrainForm : Form
    {
        public static String TRAINING_PATH;
        Form opener;

        public TrainForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;

            TRAINING_PATH = "";
        }

        private void updateTrainSet_Click(object sender, EventArgs e)
        {
            UpdateForm form = new UpdateForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(DialogResult.OK == dialog.ShowDialog())
            {
                textBoxDirectory.Text = dialog.SelectedPath;
                TRAINING_PATH = dialog.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /***
             * 0 0 0 -> 0
             * 0 0 1 -> 1
             * 0 1 0 -> 1
             * 0 1 1 -> 0
             * 1 0 0 -> 1
             * 1 0 1 -> 0
             * 1 1 0 -> 0
             * 1 1 1 -> 1
             ***/

            // Source from https://www.youtube.com/watch?v=L_PByyJ9g-I
            NeuralNetwork net = new NeuralNetwork(new int[] { 3, 25, 25, 1 });
            for(int i=0; i<5000; i++)
            {
                net.FeedForward(new float[] { 0, 0, 0 });
                net.BackProp(new float[] { 0 });

                net.FeedForward(new float[] { 0, 0, 1 });
                net.BackProp(new float[] { 1 });

                net.FeedForward(new float[] { 0, 1, 0 });
                net.BackProp(new float[] { 1 });

                net.FeedForward(new float[] { 0, 1, 1 });
                net.BackProp(new float[] { 0 });

                net.FeedForward(new float[] { 1, 0, 0 });
                net.BackProp(new float[] { 1 });

                net.FeedForward(new float[] { 1, 0, 1 });
                net.BackProp(new float[] { 0 });

                net.FeedForward(new float[] { 1, 1, 0 });
                net.BackProp(new float[] { 0 });

                net.FeedForward(new float[] { 1, 1, 1 });
                net.BackProp(new float[] { 1 });
            }

            Console.WriteLine(net.FeedForward(new float[] { 0, 0, 0 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 0, 0, 1 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 0, 1, 0 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 0, 1, 1 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 1, 0, 0 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 1, 0, 1 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 1, 1, 0 })[0]);
            Console.WriteLine(net.FeedForward(new float[] { 1, 1, 1 })[0]);
        }
    }
}
