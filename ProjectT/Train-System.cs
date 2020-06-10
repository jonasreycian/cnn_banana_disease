using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using 

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

        }
    }
}
