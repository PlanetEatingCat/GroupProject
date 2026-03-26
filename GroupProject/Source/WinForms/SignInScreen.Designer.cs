namespace BudgetPlanner
{
    partial class SignInScreen
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
            WelcomeLabel = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            SignInButton = new Button();
            UsernameInputLabel = new Label();
            PasswordInputLabel = new Label();
            SignInPanel = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SignInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Times New Roman", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(84, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(120, 35);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Welcome";
            // 
            // UsernameInput
            // 
            UsernameInput.BackColor = SystemColors.ActiveCaption;
            UsernameInput.BorderStyle = BorderStyle.None;
            UsernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameInput.Location = new Point(5, 226);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(128, 27);
            UsernameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.BackColor = SystemColors.ActiveCaption;
            PasswordInput.BorderStyle = BorderStyle.None;
            PasswordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordInput.Location = new Point(159, 226);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(125, 27);
            PasswordInput.TabIndex = 4;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = SystemColors.Highlight;
            SignInButton.FlatAppearance.BorderSize = 0;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.ForeColor = Color.White;
            SignInButton.Location = new Point(97, 298);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(95, 37);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // UsernameInputLabel
            // 
            UsernameInputLabel.AutoSize = true;
            UsernameInputLabel.BackColor = Color.Transparent;
            UsernameInputLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameInputLabel.ForeColor = Color.White;
            UsernameInputLabel.Location = new Point(29, 261);
            UsernameInputLabel.Name = "UsernameInputLabel";
            UsernameInputLabel.Size = new Size(89, 23);
            UsernameInputLabel.TabIndex = 6;
            UsernameInputLabel.Text = "Username";
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordInputLabel.ForeColor = Color.White;
            PasswordInputLabel.Location = new Point(159, 261);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(85, 23);
            PasswordInputLabel.TabIndex = 7;
            PasswordInputLabel.Text = "Password";
            PasswordInputLabel.Click += PasswordInputLabel_Click;
            // 
            // SignInPanel
            // 
            SignInPanel.Anchor = AnchorStyles.None;
            SignInPanel.BackColor = Color.White;
            SignInPanel.Controls.Add(iconPictureBox1);
            SignInPanel.Controls.Add(WelcomeLabel);
            SignInPanel.Controls.Add(PasswordInputLabel);
            SignInPanel.Controls.Add(UsernameInputLabel);
            SignInPanel.Controls.Add(UsernameInput);
            SignInPanel.Controls.Add(SignInButton);
            SignInPanel.Controls.Add(PasswordInput);
            SignInPanel.Location = new Point(308, 235);
            SignInPanel.Name = "SignInPanel";
            SignInPanel.Size = new Size(290, 359);
            SignInPanel.TabIndex = 8;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.Highlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconPictureBox1.IconColor = SystemColors.Highlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 183;
            iconPictureBox1.Location = new Point(48, 37);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(196, 183);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = SystemColors.Highlight;
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            iconButton1.IconColor = Color.SkyBlue;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 100;
            iconButton1.Location = new Point(0, 0);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(879, 152);
            iconButton1.TabIndex = 9;
            iconButton1.Text = "BUDGET PLANNER";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // SignInScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(iconButton1);
            Controls.Add(SignInPanel);
            Name = "SignInScreen";
            Size = new Size(879, 612);
            Load += SignInScreen_Load;
            SizeChanged += SignInScreen_SizeChanged;
            Resize += SignInScreen_Resize;
            SignInPanel.ResumeLayout(false);
            SignInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label WelcomeLabel;
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
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
