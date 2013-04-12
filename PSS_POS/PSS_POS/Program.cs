using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSS_POS
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
            PosForm posf = new PosForm();
            PosSystem poss = new PosSystem(posf);
            posf.setPosSystem(poss);
            Application.Run(posf);
        }
    }
}
