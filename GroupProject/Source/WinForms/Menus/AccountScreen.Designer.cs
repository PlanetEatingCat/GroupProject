namespace GroupProject.Source.WinForms.Menus
{
    partial class AccountScreen
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
            AccountIcon = new FontAwesome.Sharp.IconPictureBox();
            BackPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)AccountIcon).BeginInit();
            BackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AccountIcon
            // 
            AccountIcon.BackColor = SystemColors.GradientActiveCaption;
            AccountIcon.ForeColor = SystemColors.ControlText;
            AccountIcon.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            AccountIcon.IconColor = SystemColors.ControlText;
            AccountIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            AccountIcon.IconSize = 205;
            AccountIcon.Location = new Point(375, 44);
            AccountIcon.Name = "AccountIcon";
            AccountIcon.Size = new Size(205, 212);
            AccountIcon.TabIndex = 0;
            AccountIcon.TabStop = false;
            // 
            // BackPanel
            // 
            BackPanel.BackColor = SystemColors.GradientActiveCaption;
            BackPanel.Controls.Add(AccountIcon);
            BackPanel.Location = new Point(21, 21);
            BackPanel.Name = "BackPanel";
            BackPanel.Size = new Size(945, 555);
            BackPanel.TabIndex = 1;
            // 
            // AccountScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackPanel);
            Name = "AccountScreen";
            Size = new Size(987, 648);
            ((System.ComponentModel.ISupportInitialize)AccountIcon).EndInit();
            BackPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox AccountIcon;
        private Panel BackPanel;
    }
}
