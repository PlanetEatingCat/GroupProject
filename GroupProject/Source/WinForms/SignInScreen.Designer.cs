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
            pictureBox1 = new PictureBox();
            WelcomeLabel = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            SignInButton = new Button();
            UsernameInputLabel = new Label();
            PasswordInputLabel = new Label();
            SignInPanel = new Panel();
            TableLayoutPanel = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SignInPanel.SuspendLayout();
            TableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = GroupProject.Properties.Resources.SignIn;
            pictureBox1.Location = new Point(50, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Location = new Point(94, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(71, 20);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Welcome";
            // 
            // UsernameInput
            // 
            UsernameInput.Location = new Point(5, 219);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(125, 27);
            UsernameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            PasswordInput.Location = new Point(136, 219);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(125, 27);
            PasswordInput.TabIndex = 4;
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(84, 272);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(94, 29);
            SignInButton.TabIndex = 5;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // UsernameInputLabel
            // 
            UsernameInputLabel.AutoSize = true;
            UsernameInputLabel.Location = new Point(29, 249);
            UsernameInputLabel.Name = "UsernameInputLabel";
            UsernameInputLabel.Size = new Size(75, 20);
            UsernameInputLabel.TabIndex = 6;
            UsernameInputLabel.Text = "Username";
            // 
            // PasswordInputLabel
            // 
            PasswordInputLabel.AutoSize = true;
            PasswordInputLabel.Location = new Point(156, 249);
            PasswordInputLabel.Name = "PasswordInputLabel";
            PasswordInputLabel.Size = new Size(70, 20);
            PasswordInputLabel.TabIndex = 7;
            PasswordInputLabel.Text = "Password";
            // 
            // SignInPanel
            // 
            SignInPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SignInPanel.Controls.Add(pictureBox1);
            SignInPanel.Controls.Add(PasswordInputLabel);
            SignInPanel.Controls.Add(WelcomeLabel);
            SignInPanel.Controls.Add(UsernameInputLabel);
            SignInPanel.Controls.Add(UsernameInput);
            SignInPanel.Controls.Add(SignInButton);
            SignInPanel.Controls.Add(PasswordInput);
            SignInPanel.Location = new Point(299, 155);
            SignInPanel.Name = "SignInPanel";
            SignInPanel.Size = new Size(290, 358);
            SignInPanel.TabIndex = 8;
            // 
            // TableLayoutPanel
            // 
            TableLayoutPanel.ColumnCount = 3;
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 285F));
            TableLayoutPanel.Controls.Add(SignInPanel, 1, 1);
            TableLayoutPanel.Dock = DockStyle.Fill;
            TableLayoutPanel.Location = new Point(0, 0);
            TableLayoutPanel.Name = "TableLayoutPanel";
            TableLayoutPanel.RowCount = 3;
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.8366013F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 59.4771233F));
            TableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5228758F));
            TableLayoutPanel.Size = new Size(878, 612);
            TableLayoutPanel.TabIndex = 9;
            // 
            // SignInScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableLayoutPanel);
            Name = "SignInScreen";
            Size = new Size(878, 612);
            Load += SignInScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            SignInPanel.ResumeLayout(false);
            SignInPanel.PerformLayout();
            TableLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
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
        private TableLayoutPanel TableLayoutPanel;
    }
}
