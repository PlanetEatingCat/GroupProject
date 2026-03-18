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
            BankPanel.SuspendLayout();
            UsernamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Transactions
            // 
            Transactions.Anchor = AnchorStyles.None;
            Transactions.FormattingEnabled = true;
            Transactions.Location = new Point(209, 280);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(417, 224);
            Transactions.TabIndex = 7;
            // 
            // ConfirmBttn
            // 
            ConfirmBttn.Anchor = AnchorStyles.None;
            ConfirmBttn.Location = new Point(612, 229);
            ConfirmBttn.Margin = new Padding(4);
            ConfirmBttn.Name = "ConfirmBttn";
            ConfirmBttn.Size = new Size(118, 36);
            ConfirmBttn.TabIndex = 6;
            ConfirmBttn.Text = "Confirm";
            ConfirmBttn.UseVisualStyleBackColor = true;
            ConfirmBttn.Click += ConfirmBttn_Click;
            // 
            // AmountLbl
            // 
            AmountLbl.Anchor = AnchorStyles.None;
            AmountLbl.AutoSize = true;
            AmountLbl.Location = new Point(376, 237);
            AmountLbl.Margin = new Padding(4, 0, 4, 0);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(65, 20);
            AmountLbl.TabIndex = 5;
            AmountLbl.Text = "Amount:";
            // 
            // AmountTxtBx
            // 
            AmountTxtBx.Anchor = AnchorStyles.None;
            AmountTxtBx.Location = new Point(449, 230);
            AmountTxtBx.Margin = new Padding(4);
            AmountTxtBx.Name = "AmountTxtBx";
            AmountTxtBx.Size = new Size(155, 27);
            AmountTxtBx.TabIndex = 4;
            // 
            // WithdrawAddSelect
            // 
            WithdrawAddSelect.Anchor = AnchorStyles.None;
            WithdrawAddSelect.FormattingEnabled = true;
            WithdrawAddSelect.Items.AddRange(new object[] { "Withdraw", "Deposit" });
            WithdrawAddSelect.Location = new Point(180, 229);
            WithdrawAddSelect.Margin = new Padding(4);
            WithdrawAddSelect.Name = "WithdrawAddSelect";
            WithdrawAddSelect.Size = new Size(188, 28);
            WithdrawAddSelect.TabIndex = 3;
            // 
            // EditBalanceLbl
            // 
            EditBalanceLbl.Anchor = AnchorStyles.None;
            EditBalanceLbl.AutoSize = true;
            EditBalanceLbl.Location = new Point(382, 195);
            EditBalanceLbl.Margin = new Padding(4, 0, 4, 0);
            EditBalanceLbl.Name = "EditBalanceLbl";
            EditBalanceLbl.Size = new Size(95, 20);
            EditBalanceLbl.TabIndex = 2;
            EditBalanceLbl.Text = "Move Money";
            // 
            // BalanceTxtBx
            // 
            BalanceTxtBx.Anchor = AnchorStyles.None;
            BalanceTxtBx.Location = new Point(401, 96);
            BalanceTxtBx.Margin = new Padding(4);
            BalanceTxtBx.Name = "BalanceTxtBx";
            BalanceTxtBx.Size = new Size(155, 27);
            BalanceTxtBx.TabIndex = 1;
            BalanceTxtBx.TextChanged += BalanceTxtBx_TextChanged;
            // 
            // BalanceLbl
            // 
            BalanceLbl.Anchor = AnchorStyles.None;
            BalanceLbl.AutoSize = true;
            BalanceLbl.Location = new Point(277, 99);
            BalanceLbl.Margin = new Padding(4, 0, 4, 0);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(116, 20);
            BalanceLbl.TabIndex = 0;
            BalanceLbl.Text = "Current Balance:";
            // 
            // SavingsProgressBar
            // 
            SavingsProgressBar.Anchor = AnchorStyles.None;
            SavingsProgressBar.Location = new Point(330, 145);
            SavingsProgressBar.Margin = new Padding(4);
            SavingsProgressBar.Maximum = 10000;
            SavingsProgressBar.Name = "SavingsProgressBar";
            SavingsProgressBar.Size = new Size(308, 31);
            SavingsProgressBar.TabIndex = 8;
            // 
            // SavingsGoalLbl
            // 
            SavingsGoalLbl.Anchor = AnchorStyles.None;
            SavingsGoalLbl.AutoSize = true;
            SavingsGoalLbl.Location = new Point(180, 156);
            SavingsGoalLbl.Margin = new Padding(4, 0, 4, 0);
            SavingsGoalLbl.Name = "SavingsGoalLbl";
            SavingsGoalLbl.Size = new Size(142, 20);
            SavingsGoalLbl.TabIndex = 9;
            SavingsGoalLbl.Text = "Savings Goal ($10k):";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Location = new Point(77, 23);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(75, 20);
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
            BankPanel.Location = new Point(40, 45);
            BankPanel.Name = "BankPanel";
            BankPanel.Size = new Size(911, 582);
            BankPanel.TabIndex = 10;
            // 
            // UsernamePanel
            // 
            UsernamePanel.BackColor = SystemColors.ActiveCaption;
            UsernamePanel.Controls.Add(BackToSignInButton);
            UsernamePanel.Controls.Add(UserLabel);
            UsernamePanel.Location = new Point(0, 0);
            UsernamePanel.Name = "UsernamePanel";
            UsernamePanel.Size = new Size(173, 62);
            UsernamePanel.TabIndex = 11;
            // 
            // BackToSignInButton
            // 
            BackToSignInButton.Image = Resources.SignIn;
            BackToSignInButton.Location = new Point(17, 5);
            BackToSignInButton.Name = "BackToSignInButton";
            BackToSignInButton.Size = new Size(54, 54);
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
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.71140957F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 93.28859F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 17F));
            tableLayoutPanel1.Size = new Size(988, 648);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(UsernamePanel);
            Controls.Add(tableLayoutPanel1);
            Name = "MainScreen";
            Size = new Size(988, 648);
            Load += MainScreen_Load;
            BankPanel.ResumeLayout(false);
            BankPanel.PerformLayout();
            UsernamePanel.ResumeLayout(false);
            UsernamePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BackToSignInButton).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
    }
}
