namespace GroupProject.Source.WinForms
{
    partial class CalendarScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UserLabel = new Label();
            UsernamePanel = new Panel();
            BackToSignInButton = new PictureBox();
            UsernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).BeginInit();
            SuspendLayout();
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(96, 28);
            UserLabel.Margin = new Padding(4, 0, 4, 0);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(91, 25);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Username";
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = SystemColors.ActiveCaption;
            UsernamePanel.Controls.Add(BackToSignInButton);
            UsernamePanel.Controls.Add(UserLabel);
            UsernamePanel.Location = new Point(0, 0);
            UsernamePanel.Margin = new Padding(4, 3, 4, 3);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(216, 78);
            UsernamePanel.TabIndex = 13;
            // 
            // BackToSignInButton
            // 
            BackToSignInButton.Image = Properties.Resources.SignIn;
            BackToSignInButton.Location = new Point(21, 7);
            BackToSignInButton.Margin = new Padding(4, 3, 4, 3);
            BackToSignInButton.Name = "BackToSignInButton";
            BackToSignInButton.Size = new Size(69, 68);
            BackToSignInButton.SizeMode = PictureBoxSizeMode.StretchImage;
            BackToSignInButton.TabIndex = 1;
            BackToSignInButton.TabStop = false;
            // 
            // CalendarScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UsernamePanel);
            Name = "CalendarScreen";
            Size = new Size(1259, 773);
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label UserLabel;
        private Panel UsernamePanel;
        private PictureBox BackToSignInButton;
    }
}
