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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btn_testSystem_Click(object sender, EventArgs e)
        {
            TestForm test = new TestForm(this);
            test.Show();
        }

        private void btn_trainSystem_Click(object sender, EventArgs e)
        {
            TrainForm train = new TrainForm(this);
            train.Show();
        }

        private void btn_closeSystem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
