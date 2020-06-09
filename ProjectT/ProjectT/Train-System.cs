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
    public partial class TrainForm : Form
    {
        Form opener;

        public TrainForm(Form parentForm)
        {
            InitializeComponent();
            opener = parentForm;
        }

        private void updateTrainSet_Click(object sender, EventArgs e)
        {
            Update_form update = new Update_form();
            update.Show();
        }
    }
}
