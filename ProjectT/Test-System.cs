using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectT
{
    public partial class TestForm : Form
    {
        Form opener;

        public TestForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void btn_loadImage_Click(object sender, EventArgs e)
        {
             OpenFileDialog loadImage = new OpenFileDialog();
             loadImage.Filter = "Image Files (*.jpg; *.jpeg; *.bmp; *.gif) | *.jpg; *.jpeg; *.bmp; *.gif";
             if (loadImage.ShowDialog() == DialogResult.OK)
             {
                // bmp = new Bitmap(loadImage.FileName);
                pictureBox1.Image = new Bitmap(loadImage.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
             }
        }
    }
}
