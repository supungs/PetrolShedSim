using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSS_Manager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mForm = new Form1();
            ManagerSystem m = new ManagerSystem();
            mForm.setManagerSystem(m);
            Application.Run(mForm);
        }
    }
}
