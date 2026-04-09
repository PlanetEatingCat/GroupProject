namespace BudgetPlanner
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            SignInButton = new Button();
            UsernameInputLabel = new Label();
            PasswordInputLabel = new Label();
            SignInPanel = new Panel();
            button1 = new Button();
            SubtitleLabel = new Label();
            TitleLabel = new Label();
            checkBox1 = new CheckBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconToolStripButton1 = new FontAwesome.Sharp.IconToolStripButton();
            SidePanel = new Panel();
            ThemeComboBox = new ComboBox();
            DeveloperIcon = new FontAwesome.Sharp.IconPictureBox();
            DevelopersLabel = new Label();
            WelcomeLabel = new Label();
            label3 = new Label();
            TitleBarPanel.SuspendLayout();
            SignInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DeveloperIcon).BeginInit();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(336, 0);
            RightMenuBarPanel.Margin = new Padding(4, 5, 4, 5);
            RightMenuBarPanel.Size = new Size(0, 66);
            // 
            // MinButton
            // 
            MinButton.BackColor = Color.White;
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(336, 0);
            MinButton.Size = new Size(45, 66);
            // 
            // MaxButton
            // 
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(381, 0);
            MaxButton.Margin = new Padding(4, 5, 4, 5);
            MaxButton.Size = new Size(45, 66);
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(426, 0);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Size = new Size(45, 66);
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Margin = new Padding(4, 5, 4, 5);
            LeftMenuBarPanel.Size = new Size(0, 66);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.Location = new Point(406, 68);
            BaseMainPanel.Margin = new Padding(4, 4, 4, 4);
            BaseMainPanel.Size = new Size(471, 581);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = Color.White;
            TitleBarPanel.Location = new Point(406, 2);
            TitleBarPanel.Margin = new Padding(4, 4, 4, 4);
            TitleBarPanel.Size = new Size(471, 66);
            // 
            // UsernameInput
            // 
            UsernameInput.Anchor = AnchorStyles.None;
            UsernameInput.BackColor = Color.White;
            UsernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameInput.Location = new Point(38, 204);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(392, 34);
            UsernameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.Anchor = AnchorStyles.None;
            PasswordInput.BackColor = Color.White;
            PasswordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordInput.Location = new Point(38, 277);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(392, 34);
            PasswordInput.TabIndex = 4;
            // 
            // SignInButton
            // 
            SignInButton.Anchor = AnchorStyles.None;
            SignInButton.BackColor = SystemColors.Highlight;
            SignInButton.FlatAppearance.BorderSize = 0;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(38, 466);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(418, 54);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Login";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // UsernameInputLabel
            // 
            UsernameInputLabel.Anchor = AnchorStyles.None;
            UsernameInputLabel.AutoSize = true;
            UsernameInputLabel.BackColor = Color.Transparent;
            UsernameInputLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameInputLabel.ForeColor = Color.Black;
            UsernameInputLabel.Location = new Point(38, 178);
            UsernameInputLabel.Name = "UsernameInputLabel";
            UsernameInputLabel.Size = new Size(89, 23);
            UsernameInputLabel.TabIndex = 6;
            UsernameInputLabel.Text = "Username";
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.Anchor = AnchorStyles.None;
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordInputLabel.ForeColor = Color.Black;
            PasswordInputLabel.Location = new Point(38, 251);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(85, 23);
            PasswordInputLabel.TabIndex = 7;
            PasswordInputLabel.Text = "Password";
            // 
            // SignInPanel
            // 
            SignInPanel.BackColor = Color.White;
            SignInPanel.Controls.Add(button1);
            SignInPanel.Controls.Add(SubtitleLabel);
            SignInPanel.Controls.Add(TitleLabel);
            SignInPanel.Controls.Add(checkBox1);
            SignInPanel.Controls.Add(PasswordInputLabel);
            SignInPanel.Controls.Add(UsernameInputLabel);
            SignInPanel.Controls.Add(UsernameInput);
            SignInPanel.Controls.Add(SignInButton);
            SignInPanel.Controls.Add(PasswordInput);
            SignInPanel.Dock = DockStyle.Fill;
            SignInPanel.Location = new Point(406, 68);
            SignInPanel.Name = "SignInPanel";
            SignInPanel.Size = new Size(471, 581);
            SignInPanel.TabIndex = 8;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.Highlight;
            button1.Location = new Point(184, 545);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 11;
            button1.Text = "Forgot Password?";
            button1.UseVisualStyleBackColor = true;
            // 
            // SubtitleLabel
            // 
            SubtitleLabel.Anchor = AnchorStyles.None;
            SubtitleLabel.AutoSize = true;
            SubtitleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubtitleLabel.ForeColor = SystemColors.MenuHighlight;
            SubtitleLabel.Location = new Point(184, 85);
            SubtitleLabel.Name = "SubtitleLabel";
            SubtitleLabel.Size = new Size(112, 28);
            SubtitleLabel.TabIndex = 10;
            SubtitleLabel.Text = "User Login";
            // 
            // TitleLabel
            // 
            TitleLabel.Anchor = AnchorStyles.None;
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = SystemColors.MenuHighlight;
            TitleLabel.Location = new Point(128, 34);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(228, 32);
            TitleLabel.TabIndex = 9;
            TitleLabel.Text = "Budget Planner";
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(38, 412);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Remember me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Highlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 166;
            iconPictureBox1.Location = new Point(128, 53);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(166, 170);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // iconToolStripButton1
            // 
            iconToolStripButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconToolStripButton1.IconColor = Color.Black;
            iconToolStripButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconToolStripButton1.Name = "iconToolStripButton1";
            iconToolStripButton1.Size = new Size(23, 23);
            iconToolStripButton1.Text = "iconToolStripButton1";
            // 
            // SidePanel
            // 
            SidePanel.BackColor = SystemColors.Highlight;
            SidePanel.Controls.Add(ThemeComboBox);
            SidePanel.Controls.Add(DeveloperIcon);
            SidePanel.Controls.Add(DevelopersLabel);
            SidePanel.Controls.Add(WelcomeLabel);
            SidePanel.Controls.Add(label3);
            SidePanel.Controls.Add(iconPictureBox1);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(2, 2);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(404, 647);
            SidePanel.TabIndex = 9;
            // 
            // ThemeComboBox
            // 
            ThemeComboBox.Anchor = AnchorStyles.Bottom;
            ThemeComboBox.FormattingEnabled = true;
            ThemeComboBox.Location = new Point(128, 532);
            ThemeComboBox.Margin = new Padding(2, 2, 2, 2);
            ThemeComboBox.Name = "ThemeComboBox";
            ThemeComboBox.Size = new Size(146, 28);
            ThemeComboBox.TabIndex = 14;
            ThemeComboBox.SelectedIndexChanged += ThemeComboBox_SelectedIndexChanged;
            // 
            // DeveloperIcon
            // 
            DeveloperIcon.Anchor = AnchorStyles.Bottom;
            DeveloperIcon.BackColor = SystemColors.Highlight;
            DeveloperIcon.IconChar = FontAwesome.Sharp.IconChar.Dev;
            DeveloperIcon.IconColor = Color.White;
            DeveloperIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            DeveloperIcon.IconSize = 40;
            DeveloperIcon.Location = new Point(68, 612);
            DeveloperIcon.Name = "DeveloperIcon";
            DeveloperIcon.Size = new Size(40, 40);
            DeveloperIcon.TabIndex = 13;
            DeveloperIcon.TabStop = false;
            // 
            // DevelopersLabel
            // 
            DevelopersLabel.Anchor = AnchorStyles.Bottom;
            DevelopersLabel.AutoSize = true;
            DevelopersLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DevelopersLabel.ForeColor = Color.White;
            DevelopersLabel.Location = new Point(102, 612);
            DevelopersLabel.Name = "DevelopersLabel";
            DevelopersLabel.Size = new Size(283, 28);
            DevelopersLabel.TabIndex = 12;
            DevelopersLabel.Text = "Kiefer, Ella, Beza, Daniel, Khai";
            DevelopersLabel.Click += DevelopersLabel_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(145, 235);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(120, 35);
            WelcomeLabel.TabIndex = 11;
            WelcomeLabel.Text = "Welcome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 281);
            label3.Name = "label3";
            label3.Size = new Size(341, 60);
            label3.TabIndex = 10;
            label3.Text = "This is a budgeting and scheduling app that \r\nkeeps track of user income and spending habits\r\n to create a maintainable budget and lifestyle. \r\n";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 651);
            Controls.Add(SignInPanel);
            Controls.Add(SidePanel);
            Location = new Point(0, 0);
            Name = "LoginForm";
            Padding = new Padding(2);
            Load += SignInScreen_Load;
            SizeChanged += SignInScreen_SizeChanged;
            Resize += SignInScreen_Resize;
            Controls.SetChildIndex(SidePanel, 0);
            Controls.SetChildIndex(TitleBarPanel, 0);
            Controls.SetChildIndex(BaseMainPanel, 0);
            Controls.SetChildIndex(SignInPanel, 0);
            TitleBarPanel.ResumeLayout(false);
            SignInPanel.ResumeLayout(false);
            SignInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DeveloperIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox LastNameInput;
        private TextBox FirstNameInput;
        private Label LastNameInputLabel;
        private Label FirstNameInputLabel;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Button SignInButton;
        private Label UsernameInputLabel;
        private Label PasswordInputLabel;
        private Panel SignInPanel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label TitleLabel;
        private CheckBox checkBox1;
        private Label SubtitleLabel;
        private FontAwesome.Sharp.IconToolStripButton iconToolStripButton1;
        private Button button1;
        private Panel SidePanel;
        private Label label3;
        private Label WelcomeLabel;
        private Label DevelopersLabel;
        private FontAwesome.Sharp.IconPictureBox DeveloperIcon;
        private ComboBox ThemeComboBox;
    }
}