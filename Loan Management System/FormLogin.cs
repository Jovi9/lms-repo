using Loan_Management_System.Forms;
using Loan_Management_System.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Management_System
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.terminateProgram = true;
            //Console.WriteLine(Application.OpenForms.Count.ToString());
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;

            if (username.Trim() == "" && password.Trim() == "")
            {
                LblEmptyUsername.Visible = true;
                LblEmtyPassword.Visible = true;
                TxtUsername.Select();
            }else if(username.Trim()=="" && !(password.Trim() == ""))
            {
                LblEmptyUsername.Visible = true;
                TxtUsername.Select();
            }else if (!(username.Trim()=="") && password.Trim() == "")
            {
                LblEmtyPassword.Visible = true;
                TxtPassword.Select();
            }
            else
            {
                BtnLogin.Text = "Verifying...";
                UserAccountFunction userAccountFunction = new UserAccountFunction();
                if (userAccountFunction.AuthenticateLoginCredentials(username, password))
                {
                    Program.isLoggedIN = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Login Denied: Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BtnLogin.Text = "Login";
                    TxtUsername.Select();
                    TxtUsername.SelectAll();
                }
            }
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            LblEmptyUsername.Visible = false;
        }

        private void TxtUsername_Enter(object sender, EventArgs e)
        {
            if (!(TxtUsername.Text.Trim() == ""))
            {
                TxtUsername.SelectAll();
            }
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            LblEmtyPassword.Visible = false;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (!(TxtPassword.Text.Trim() == ""))
            {
                TxtPassword.SelectAll();
            }
        }
    }
}
