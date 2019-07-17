using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson10A
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //MainForm mainForm = new MainForm();
            //mainForm.parent = this;
            //mainForm.Show();

            Program.Forms[FormName.MAIN_FORM].Show();
            this.Hide();

        }
    }
}
