
namespace Loan_Management_System
{
    partial class FormSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSplashScreen));
            this.TimerSplash = new System.Windows.Forms.Timer(this.components);
            this.ProgressBarLoading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TimerSplash
            // 
            this.TimerSplash.Tick += new System.EventHandler(this.TimerSplash_Tick);
            // 
            // ProgressBarLoading
            // 
            this.ProgressBarLoading.Location = new System.Drawing.Point(50, 329);
            this.ProgressBarLoading.Name = "ProgressBarLoading";
            this.ProgressBarLoading.Size = new System.Drawing.Size(352, 23);
            this.ProgressBarLoading.TabIndex = 0;
            this.ProgressBarLoading.Visible = false;
            // 
            // FormSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loan_Management_System.Properties.Resources.welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.ControlBox = false;
            this.Controls.Add(this.ProgressBarLoading);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(450, 400);
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "FormSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FormSplashScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormSplashScreen_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSplashScreen_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerSplash;
        private System.Windows.Forms.ProgressBar ProgressBarLoading;
    }
}

