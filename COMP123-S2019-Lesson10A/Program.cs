using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson10A
{
    public static class Program  //make it public
    {
        //public static StartForm startForm;   too wordy if you have 100 forms
        //public static MainForm mainForm;
        //public static EndForm endForm;

        public static Dictionary<FormName, Form> Forms; //dictionary is a collection, not initiated yet


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.MAIN_FORM, new MainForm());
            Forms.Add(FormName.END_FORM, new EndForm());

            Application.Run(Forms[FormName.START_FORM]);
        }
    }
}
