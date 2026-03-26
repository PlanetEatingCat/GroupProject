using GroupProject.Properties;

namespace BudgetPlanner
{
    partial class PaymentScreen
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
            ExpenseTypeTxtBox = new TextBox();
            ExpenseTypeLbl = new Label();
            BalanceTxtBx = new TextBox();
            SavingsProgressBar = new ProgressBar();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            BalanceLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Transactions
            // 
            Transactions.BackColor = SystemColors.ActiveCaption;
            Transactions.BorderStyle = BorderStyle.FixedSingle;
            Transactions.Dock = DockStyle.Bottom;
            Transactions.FormattingEnabled = true;
            Transactions.ItemHeight = 25;
            Transactions.Location = new Point(0, 533);
            Transactions.Margin = new Padding(4, 3, 4, 3);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(1234, 277);
            Transactions.TabIndex = 7;
            // 
            // ConfirmBttn
            // 
            ConfirmBttn.BackColor = SystemColors.Highlight;
            ConfirmBttn.Dock = DockStyle.Right;
            ConfirmBttn.FlatAppearance.BorderSize = 0;
            ConfirmBttn.FlatStyle = FlatStyle.Flat;
            ConfirmBttn.ForeColor = Color.White;
            ConfirmBttn.Location = new Point(1085, 0);
            ConfirmBttn.Margin = new Padding(6, 5, 6, 5);
            ConfirmBttn.Name = "ConfirmBttn";
            ConfirmBttn.Size = new Size(149, 37);
            ConfirmBttn.TabIndex = 6;
            ConfirmBttn.Text = "Confirm";
            ConfirmBttn.UseVisualStyleBackColor = false;
            ConfirmBttn.Click += ConfirmBttn_Click;
            // 
            // AmountLbl
            // 
            AmountLbl.AutoSize = true;
            AmountLbl.BackColor = Color.Transparent;
            AmountLbl.Dock = DockStyle.Right;
            AmountLbl.ForeColor = Color.White;
            AmountLbl.Location = new Point(811, 0);
            AmountLbl.Margin = new Padding(6, 0, 6, 0);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(81, 25);
            AmountLbl.TabIndex = 5;
            AmountLbl.Text = "Amount:";
            // 
            // AmountTxtBx
            // 
            AmountTxtBx.BackColor = SystemColors.ActiveCaption;
            AmountTxtBx.BorderStyle = BorderStyle.FixedSingle;
            AmountTxtBx.Dock = DockStyle.Right;
            AmountTxtBx.ForeColor = SystemColors.WindowText;
            AmountTxtBx.Location = new Point(892, 0);
            AmountTxtBx.Margin = new Padding(6, 5, 6, 5);
            AmountTxtBx.Name = "AmountTxtBx";
            AmountTxtBx.Size = new Size(193, 31);
            AmountTxtBx.TabIndex = 4;
            // 
            // WithdrawAddSelect
            // 
            WithdrawAddSelect.BackColor = SystemColors.ActiveCaption;
            WithdrawAddSelect.Dock = DockStyle.Left;
            WithdrawAddSelect.FlatStyle = FlatStyle.Flat;
            WithdrawAddSelect.FormattingEnabled = true;
            WithdrawAddSelect.Items.AddRange(new object[] { "Add Expense", "Deposit" });
            WithdrawAddSelect.Location = new Point(0, 0);
            WithdrawAddSelect.Margin = new Padding(6, 5, 6, 5);
            WithdrawAddSelect.Name = "WithdrawAddSelect";
            WithdrawAddSelect.Size = new Size(234, 33);
            WithdrawAddSelect.TabIndex = 3;
            WithdrawAddSelect.SelectedIndexChanged += WithdrawAddSelect_SelectedIndexChanged;
            // 
            // EditBalanceLbl
            // 
            EditBalanceLbl.Anchor = AnchorStyles.None;
            EditBalanceLbl.AutoSize = true;
            EditBalanceLbl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBalanceLbl.ForeColor = Color.White;
            EditBalanceLbl.Location = new Point(513, 452);
            EditBalanceLbl.Margin = new Padding(6, 0, 6, 0);
            EditBalanceLbl.Name = "EditBalanceLbl";
            EditBalanceLbl.Size = new Size(224, 30);
            EditBalanceLbl.TabIndex = 2;
            EditBalanceLbl.Text = "Move Money/ History";
            // 
            // ExpenseTypeTxtBox
            // 
            ExpenseTypeTxtBox.BackColor = SystemColors.ActiveCaption;
            ExpenseTypeTxtBox.BorderStyle = BorderStyle.FixedSingle;
            ExpenseTypeTxtBox.Dock = DockStyle.Fill;
            ExpenseTypeTxtBox.Location = new Point(356, 0);
            ExpenseTypeTxtBox.Name = "ExpenseTypeTxtBox";
            ExpenseTypeTxtBox.Size = new Size(455, 31);
            ExpenseTypeTxtBox.TabIndex = 11;
            ExpenseTypeTxtBox.TextChanged += ExpenseTypeTxtBox_TextChanged;
            // 
            // ExpenseTypeLbl
            // 
            ExpenseTypeLbl.AutoSize = true;
            ExpenseTypeLbl.Dock = DockStyle.Left;
            ExpenseTypeLbl.ForeColor = Color.White;
            ExpenseTypeLbl.Location = new Point(234, 0);
            ExpenseTypeLbl.Name = "ExpenseTypeLbl";
            ExpenseTypeLbl.Size = new Size(122, 25);
            ExpenseTypeLbl.TabIndex = 10;
            ExpenseTypeLbl.Text = "Expense Type:";
            ExpenseTypeLbl.Click += ExpenseTypeLbl_Click;
            // 
            // BalanceTxtBx
            // 
            BalanceTxtBx.Anchor = AnchorStyles.None;
            BalanceTxtBx.BackColor = SystemColors.ActiveCaption;
            BalanceTxtBx.BorderStyle = BorderStyle.None;
            BalanceTxtBx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BalanceTxtBx.Location = new Point(531, 261);
            BalanceTxtBx.Margin = new Padding(6, 5, 6, 5);
            BalanceTxtBx.Name = "BalanceTxtBx";
            BalanceTxtBx.Size = new Size(194, 28);
            BalanceTxtBx.TabIndex = 1;
            BalanceTxtBx.TextChanged += BalanceTxtBx_TextChanged;
            // 
            // SavingsProgressBar
            // 
            SavingsProgressBar.BackColor = SystemColors.ControlDarkDark;
            SavingsProgressBar.Dock = DockStyle.Fill;
            SavingsProgressBar.Location = new Point(0, 0);
            SavingsProgressBar.Margin = new Padding(6, 5, 6, 5);
            SavingsProgressBar.Maximum = 10000;
            SavingsProgressBar.Name = "SavingsProgressBar";
            SavingsProgressBar.Size = new Size(1147, 88);
            SavingsProgressBar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(SavingsProgressBar);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 88);
            panel1.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Dock = DockStyle.Right;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 87;
            iconPictureBox1.Location = new Point(1147, 0);
            iconPictureBox1.Margin = new Padding(4, 3, 4, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(87, 88);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(ExpenseTypeTxtBox);
            panel2.Controls.Add(AmountLbl);
            panel2.Controls.Add(ExpenseTypeLbl);
            panel2.Controls.Add(WithdrawAddSelect);
            panel2.Controls.Add(AmountTxtBx);
            panel2.Controls.Add(ConfirmBttn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 496);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1234, 37);
            panel2.TabIndex = 13;
            // 
            // BalanceLbl
            // 
            BalanceLbl.Anchor = AnchorStyles.None;
            BalanceLbl.AutoSize = true;
            BalanceLbl.ForeColor = Color.White;
            BalanceLbl.Location = new Point(560, 231);
            BalanceLbl.Margin = new Padding(6, 0, 6, 0);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(138, 25);
            BalanceLbl.TabIndex = 0;
            BalanceLbl.Text = "Current Balance:";
            // 
            // PaymentScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BalanceTxtBx);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Transactions);
            Controls.Add(BalanceLbl);
            Controls.Add(EditBalanceLbl);
            Margin = new Padding(4, 3, 4, 3);
            Name = "PaymentScreen";
            Size = new Size(1234, 810);
            Load += MainScreen_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ExpenseTypeLbl;
        private ComboBox WithdrawAddSelect;
        private Label EditBalanceLbl;
        private TextBox BalanceTxtBx;
        private Label AmountLbl;
        private TextBox AmountTxtBx;
        private Button ConfirmBttn;
        private ListBox Transactions;
        private ProgressBar SavingsProgressBar;
        private TextBox ExpenseTypeTxtBox;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Label BalanceLbl;
    }
}
