using Loan_Management_System.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Management_System
{
    static class Program
    {
        public static bool isLoggedIN = false;
        public static bool terminateProgram = false;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSplashScreen());

            while (isLoggedIN == false)
            {
                Application.Run(new FormLogin());
                if (isLoggedIN == true)
                {
                    Application.Run(new FormMain());
                }
                if (terminateProgram)
                {
                    //Console.WriteLine(terminateProgram);
                    break;
                }               
            }
        }
    }
}
