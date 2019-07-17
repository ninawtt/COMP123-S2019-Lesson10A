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
    public partial class MainForm : Form
    {
        //public Form parent { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            //this.parent.Show();
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            //EndForm endForm = new EndForm();
            //endForm.parent = this;
            //endForm.Show();
            Program.Forms[FormName.END_FORM].Show();
            this.Hide(); 
        }
    }
}
