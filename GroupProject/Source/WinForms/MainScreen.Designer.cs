using GroupProject.Properties;

namespace BudgetPlanner
{
    partial class MainScreen
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
            Transactions = new ListBox();
            ConfirmBttn = new Button();
            AmountLbl = new Label();
            AmountTxtBx = new TextBox();
            WithdrawAddSelect = new ComboBox();
            EditBalanceLbl = new Label();
            BalanceTxtBx = new TextBox();
            BalanceLbl = new Label();
            SavingsProgressBar = new ProgressBar();
            SavingsGoalLbl = new Label();
            UserLabel = new Label();
            BankPanel = new Panel();
            UsernamePanel = new Panel();
            BackToSignInButton = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            BankPanel.SuspendLayout();
            UsernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Transactions
            // 
            Transactions.Anchor = AnchorStyles.None;
            Transactions.FormattingEnabled = true;
            Transactions.ItemHeight = 25;
            Transactions.Location = new Point(261, 350);
            Transactions.Margin = new Padding(4, 4, 4, 4);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(520, 279);
            Transactions.TabIndex = 7;
            // 
            // ConfirmBttn
            // 
            ConfirmBttn.Anchor = AnchorStyles.None;
            ConfirmBttn.Location = new Point(765, 286);
            ConfirmBttn.Margin = new Padding(5, 5, 5, 5);
            ConfirmBttn.Name = "ConfirmBttn";
            ConfirmBttn.Size = new Size(148, 45);
            ConfirmBttn.TabIndex = 6;
            ConfirmBttn.Text = "Confirm";
            ConfirmBttn.UseVisualStyleBackColor = true;
            ConfirmBttn.Click += ConfirmBttn_Click;
            // 
            // AmountLbl
            // 
            AmountLbl.Anchor = AnchorStyles.None;
            AmountLbl.AutoSize = true;
            AmountLbl.Location = new Point(470, 296);
            AmountLbl.Margin = new Padding(5, 0, 5, 0);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(81, 25);
            AmountLbl.TabIndex = 5;
            AmountLbl.Text = "Amount:";
            // 
            // AmountTxtBx
            // 
            AmountTxtBx.Anchor = AnchorStyles.None;
            AmountTxtBx.Location = new Point(561, 288);
            AmountTxtBx.Margin = new Padding(5, 5, 5, 5);
            AmountTxtBx.Name = "AmountTxtBx";
            AmountTxtBx.Size = new Size(193, 31);
            AmountTxtBx.TabIndex = 4;
            // 
            // WithdrawAddSelect
            // 
            WithdrawAddSelect.Anchor = AnchorStyles.None;
            WithdrawAddSelect.FormattingEnabled = true;
            WithdrawAddSelect.Items.AddRange(new object[] { "Withdraw", "Deposit" });
            WithdrawAddSelect.Location = new Point(225, 286);
            WithdrawAddSelect.Margin = new Padding(5, 5, 5, 5);
            WithdrawAddSelect.Name = "WithdrawAddSelect";
            WithdrawAddSelect.Size = new Size(234, 33);
            WithdrawAddSelect.TabIndex = 3;
            // 
            // EditBalanceLbl
            // 
            EditBalanceLbl.Anchor = AnchorStyles.None;
            EditBalanceLbl.AutoSize = true;
            EditBalanceLbl.Location = new Point(478, 244);
            EditBalanceLbl.Margin = new Padding(5, 0, 5, 0);
            EditBalanceLbl.Name = "EditBalanceLbl";
            EditBalanceLbl.Size = new Size(117, 25);
            EditBalanceLbl.TabIndex = 2;
            EditBalanceLbl.Text = "Move Money";
            // 
            // BalanceTxtBx
            // 
            BalanceTxtBx.Anchor = AnchorStyles.None;
            BalanceTxtBx.Location = new Point(501, 120);
            BalanceTxtBx.Margin = new Padding(5, 5, 5, 5);
            BalanceTxtBx.Name = "BalanceTxtBx";
            BalanceTxtBx.Size = new Size(193, 31);
            BalanceTxtBx.TabIndex = 1;
            BalanceTxtBx.TextChanged += BalanceTxtBx_TextChanged;
            // 
            // BalanceLbl
            // 
            BalanceLbl.Anchor = AnchorStyles.None;
            BalanceLbl.AutoSize = true;
            BalanceLbl.Location = new Point(346, 124);
            BalanceLbl.Margin = new Padding(5, 0, 5, 0);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(138, 25);
            BalanceLbl.TabIndex = 0;
            BalanceLbl.Text = "Current Balance:";
            // 
            // SavingsProgressBar
            // 
            SavingsProgressBar.Anchor = AnchorStyles.None;
            SavingsProgressBar.Location = new Point(412, 181);
            SavingsProgressBar.Margin = new Padding(5, 5, 5, 5);
            SavingsProgressBar.Maximum = 10000;
            SavingsProgressBar.Name = "SavingsProgressBar";
            SavingsProgressBar.Size = new Size(385, 39);
            SavingsProgressBar.TabIndex = 8;
            // 
            // SavingsGoalLbl
            // 
            SavingsGoalLbl.Anchor = AnchorStyles.None;
            SavingsGoalLbl.AutoSize = true;
            SavingsGoalLbl.Location = new Point(225, 195);
            SavingsGoalLbl.Margin = new Padding(5, 0, 5, 0);
            SavingsGoalLbl.Name = "SavingsGoalLbl";
            SavingsGoalLbl.Size = new Size(172, 25);
            SavingsGoalLbl.TabIndex = 9;
            SavingsGoalLbl.Text = "Savings Goal ($10k):";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(96, 29);
            UserLabel.Margin = new Padding(4, 0, 4, 0);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(91, 25);
            UserLabel.TabIndex = 0;
            UserLabel.Text = "Username";
            // 
            // BankPanel
            // 
            BankPanel.Controls.Add(Transactions);
            BankPanel.Controls.Add(ConfirmBttn);
            BankPanel.Controls.Add(AmountLbl);
            BankPanel.Controls.Add(AmountTxtBx);
            BankPanel.Controls.Add(WithdrawAddSelect);
            BankPanel.Controls.Add(EditBalanceLbl);
            BankPanel.Controls.Add(BalanceTxtBx);
            BankPanel.Controls.Add(BalanceLbl);
            BankPanel.Controls.Add(SavingsProgressBar);
            BankPanel.Controls.Add(SavingsGoalLbl);
            BankPanel.Dock = DockStyle.Fill;
            BankPanel.Location = new Point(51, 56);
            BankPanel.Margin = new Padding(4, 4, 4, 4);
            BankPanel.Name = "BankPanel";
            BankPanel.Size = new Size(1139, 728);
            BankPanel.TabIndex = 10;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = SystemColors.ActiveCaption;
            UsernamePanel.Controls.Add(BackToSignInButton);
            UsernamePanel.Controls.Add(UserLabel);
            UsernamePanel.Location = new Point(0, 0);
            UsernamePanel.Margin = new Padding(4, 4, 4, 4);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(216, 78);
            UsernamePanel.TabIndex = 11;
            // 
            // BackToSignInButton
            // 
            BackToSignInButton.Image = Resources.SignIn;
            BackToSignInButton.Location = new Point(21, 6);
            BackToSignInButton.Margin = new Padding(4, 4, 4, 4);
            BackToSignInButton.Name = "BackToSignInButton";
            BackToSignInButton.Size = new Size(68, 68);
            BackToSignInButton.SizeMode = PictureBoxSizeMode.StretchImage;
            BackToSignInButton.TabIndex = 1;
            BackToSignInButton.TabStop = false;
            BackToSignInButton.Click += BackToSignInButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.80710649F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.8934F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.29949236F));
            tableLayoutPanel1.Controls.Add(BankPanel, 1, 1);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.71140957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.28859F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            tableLayoutPanel1.Size = new Size(1235, 810);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(184, 3);
            button1.Name = "button1";
            button1.Size = new Size(129, 40);
            button1.TabIndex = 10;
            button1.Text = "Calendar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(50, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1141, 46);
            panel1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(319, 3);
            button2.Name = "button2";
            button2.Size = new Size(129, 40);
            button2.TabIndex = 11;
            button2.Text = "Analytics";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UsernamePanel);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainScreen";
            Size = new Size(1235, 810);
            Load += MainScreen_Load;
            BankPanel.ResumeLayout(false);
            BankPanel.PerformLayout();
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label UserLabel;
        private Label label1;
        private Label BalanceLbl;
        private ComboBox WithdrawAddSelect;
        private Label EditBalanceLbl;
        private TextBox BalanceTxtBx;
        private Label AmountLbl;
        private TextBox AmountTxtBx;
        private Button ConfirmBttn;
        private ListBox Transactions;
        private ProgressBar SavingsProgressBar;
        private Label SavingsGoalLbl;
        private Panel BankPanel;
        private Panel UsernamePanel;
        private PictureBox BackToSignInButton;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}
