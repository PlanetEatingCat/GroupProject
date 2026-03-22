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
            monthCalendar1 = new MonthCalendar();
            UsernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).BeginInit();
            SuspendLayout();
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(67, 17);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(60, 15);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Username";
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = SystemColors.ActiveCaption;
            UsernamePanel.Controls.Add(BackToSignInButton);
            UsernamePanel.Controls.Add(UserLabel);
            UsernamePanel.Location = new Point(0, 0);
            UsernamePanel.Margin = new Padding(3, 2, 3, 2);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(151, 47);
            UsernamePanel.TabIndex = 13;
            // 
            // BackToSignInButton
            // 
            BackToSignInButton.Image = Properties.Resources.SignIn;
            BackToSignInButton.Location = new Point(15, 4);
            BackToSignInButton.Margin = new Padding(3, 2, 3, 2);
            BackToSignInButton.Name = "BackToSignInButton";
            BackToSignInButton.Size = new Size(48, 41);
            BackToSignInButton.SizeMode = PictureBoxSizeMode.StretchImage;
            BackToSignInButton.TabIndex = 1;
            BackToSignInButton.TabStop = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 3);
            monthCalendar1.Dock = DockStyle.Fill;
            monthCalendar1.Location = new Point(0, 0);
            monthCalendar1.Margin = new Padding(6, 5, 6, 5);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 14;
            // 
            // CalendarScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UsernamePanel);
            Controls.Add(monthCalendar1);
            Margin = new Padding(2);
            Name = "CalendarScreen";
            Size = new Size(881, 464);
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label UserLabel;
        private Panel UsernamePanel;
        private PictureBox BackToSignInButton;
        private MonthCalendar monthCalendar1;
    }
}
