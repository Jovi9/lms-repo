
namespace Loan_Management_System
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PnlLoginHeader = new System.Windows.Forms.Panel();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.HeaderTitle = new System.Windows.Forms.Label();
            this.HeaderLogo = new System.Windows.Forms.PictureBox();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.PicUsername = new System.Windows.Forms.PictureBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.LblEmtyPassword = new System.Windows.Forms.Label();
            this.LblEmptyUsername = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PnlLoginHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsername)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlLoginHeader
            // 
            this.PnlLoginHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.PnlLoginHeader.Controls.Add(this.BtnQuit);
            this.PnlLoginHeader.Controls.Add(this.HeaderTitle);
            this.PnlLoginHeader.Controls.Add(this.HeaderLogo);
            this.PnlLoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLoginHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlLoginHeader.Name = "PnlLoginHeader";
            this.PnlLoginHeader.Size = new System.Drawing.Size(531, 40);
            this.PnlLoginHeader.TabIndex = 25;
            // 
            // BtnQuit
            // 
            this.BtnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnQuit.FlatAppearance.BorderSize = 0;
            this.BtnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuit.Font = new System.Drawing.Font("Marlett", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BtnQuit.ForeColor = System.Drawing.Color.White;
            this.BtnQuit.Location = new System.Drawing.Point(475, 0);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(56, 40);
            this.BtnQuit.TabIndex = 3;
            this.BtnQuit.TabStop = false;
            this.BtnQuit.Text = "r";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // HeaderTitle
            // 
            this.HeaderTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderTitle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderTitle.ForeColor = System.Drawing.Color.White;
            this.HeaderTitle.Location = new System.Drawing.Point(40, 0);
            this.HeaderTitle.Name = "HeaderTitle";
            this.HeaderTitle.Size = new System.Drawing.Size(214, 40);
            this.HeaderTitle.TabIndex = 7;
            this.HeaderTitle.Text = "Loan Management";
            this.HeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeaderLogo
            // 
            this.HeaderLogo.BackgroundImage = global::Loan_Management_System.Properties.Resources.icon_header;
            this.HeaderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeaderLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderLogo.Location = new System.Drawing.Point(0, 0);
            this.HeaderLogo.Name = "HeaderLogo";
            this.HeaderLogo.Size = new System.Drawing.Size(40, 40);
            this.HeaderLogo.TabIndex = 8;
            this.HeaderLogo.TabStop = false;
            // 
            // PicPassword
            // 
            this.PicPassword.BackColor = System.Drawing.Color.Transparent;
            this.PicPassword.Image = global::Loan_Management_System.Properties.Resources.login_pass;
            this.PicPassword.Location = new System.Drawing.Point(35, 564);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(54, 52);
            this.PicPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPassword.TabIndex = 33;
            this.PicPassword.TabStop = false;
            // 
            // PicUsername
            // 
            this.PicUsername.BackColor = System.Drawing.Color.Transparent;
            this.PicUsername.Image = global::Loan_Management_System.Properties.Resources.login_user;
            this.PicUsername.Location = new System.Drawing.Point(35, 458);
            this.PicUsername.Name = "PicUsername";
            this.PicUsername.Size = new System.Drawing.Size(54, 52);
            this.PicUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicUsername.TabIndex = 34;
            this.PicUsername.TabStop = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(95, 564);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(400, 52);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            // 
            // TxtUsername
            // 
            this.TxtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtUsername.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.Location = new System.Drawing.Point(95, 458);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(400, 52);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            this.TxtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            // 
            // LblEmtyPassword
            // 
            this.LblEmtyPassword.AutoSize = true;
            this.LblEmtyPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblEmtyPassword.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmtyPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.LblEmtyPassword.Location = new System.Drawing.Point(95, 619);
            this.LblEmtyPassword.Name = "LblEmtyPassword";
            this.LblEmtyPassword.Size = new System.Drawing.Size(212, 23);
            this.LblEmtyPassword.TabIndex = 31;
            this.LblEmtyPassword.Text = "Password is empty";
            this.LblEmtyPassword.Visible = false;
            // 
            // LblEmptyUsername
            // 
            this.LblEmptyUsername.AutoSize = true;
            this.LblEmptyUsername.BackColor = System.Drawing.Color.Transparent;
            this.LblEmptyUsername.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmptyUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.LblEmptyUsername.Location = new System.Drawing.Point(95, 513);
            this.LblEmptyUsername.Name = "LblEmptyUsername";
            this.LblEmptyUsername.Size = new System.Drawing.Size(217, 23);
            this.LblEmptyUsername.TabIndex = 32;
            this.LblEmptyUsername.Text = "Username is empty";
            this.LblEmptyUsername.Visible = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(80)))));
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Image = global::Loan_Management_System.Properties.Resources.btnLogin;
            this.BtnLogin.Location = new System.Drawing.Point(265, 673);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(230, 53);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.TabStop = false;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loan_Management_System.Properties.Resources.frmLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.BtnQuit;
            this.ClientSize = new System.Drawing.Size(531, 770);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.PicPassword);
            this.Controls.Add(this.PicUsername);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.LblEmtyPassword);
            this.Controls.Add(this.LblEmptyUsername);
            this.Controls.Add(this.PnlLoginHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(531, 770);
            this.MinimumSize = new System.Drawing.Size(531, 770);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogin_FormClosed);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.PnlLoginHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicUsername)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Panel PnlLoginHeader;
        internal System.Windows.Forms.Button BtnQuit;
        internal System.Windows.Forms.Label HeaderTitle;
        internal System.Windows.Forms.PictureBox HeaderLogo;
        internal System.Windows.Forms.PictureBox PicPassword;
        internal System.Windows.Forms.PictureBox PicUsername;
        internal System.Windows.Forms.TextBox TxtPassword;
        internal System.Windows.Forms.TextBox TxtUsername;
        internal System.Windows.Forms.Label LblEmtyPassword;
        internal System.Windows.Forms.Label LblEmptyUsername;
        internal System.Windows.Forms.Button BtnLogin;
    }
}