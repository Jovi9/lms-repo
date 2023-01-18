using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Management_System
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void FormSplashScreen_Load(object sender, EventArgs e)
        {
            ProgressBarLoading.Value = 0;
            TimerSplash.Start();            
        }

        private void TimerSplash_Tick(object sender, EventArgs e)
        {
            ProgressBarLoading.Increment(20);
            //if (ProgressBarLoading.Value == 50)
            //{
            //    TimerSplash.Stop();
            //}
            //TimerSplash.Start();
            if (ProgressBarLoading.Value == 100)
            {
                Program.isLoggedIN = false;
                TimerSplash.Stop();
                Close();
            }
        }

        private void FormSplashScreen_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            int chgcorn = 110;

            Rectangle r1 = new Rectangle(0, this.Height - chgcorn, chgcorn, chgcorn);
            Rectangle r2 = new Rectangle(this.Width - chgcorn + 1, this.Height - chgcorn, chgcorn, chgcorn);

            // creating the upper Arc
            gp.AddArc(0, 0, chgcorn, chgcorn, 180, 90);
            gp.AddArc(this.Width - chgcorn + 1, 0, chgcorn, chgcorn, 270, 90);

            // Creating the Body
            gp.AddRectangle(new Rectangle(0, chgcorn / 2, this.Width, this.Height - chgcorn));

            // creating the lower Arc
            gp.AddArc(r1, -270, 90);
            gp.AddArc(r2, 360, 90);

            Region = new Region(gp);
        }

        private void FormSplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt & e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }
    }
}
