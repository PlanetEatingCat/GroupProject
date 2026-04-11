using GroupProject.Properties;

namespace BudgetPlanner
{
    partial class ExpenseScreen
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
            ExpenseTypeLbl = new Label();
            BalanceTxtBx = new TextBox();
            SavingsProgressBar = new ProgressBar();
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel2 = new Panel();
            ExpenseTypeComboBox = new ComboBox();
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
            Transactions.Location = new Point(0, 426);
            Transactions.Margin = new Padding(3, 2, 3, 2);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(987, 222);
            Transactions.TabIndex = 7;
            // 
            // ConfirmBttn
            // 
            ConfirmBttn.BackColor = SystemColors.Highlight;
            ConfirmBttn.Dock = DockStyle.Right;
            ConfirmBttn.FlatAppearance.BorderSize = 0;
            ConfirmBttn.FlatStyle = FlatStyle.Flat;
            ConfirmBttn.ForeColor = Color.White;
            ConfirmBttn.Location = new Point(868, 0);
            ConfirmBttn.Margin = new Padding(5, 4, 5, 4);
            ConfirmBttn.Name = "ConfirmBttn";
            ConfirmBttn.Size = new Size(119, 30);
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
            AmountLbl.Location = new Point(648, 0);
            AmountLbl.Margin = new Padding(5, 0, 5, 0);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(65, 20);
            AmountLbl.TabIndex = 5;
            AmountLbl.Text = "Amount:";
            // 
            // AmountTxtBx
            // 
            AmountTxtBx.BackColor = SystemColors.ActiveCaption;
            AmountTxtBx.BorderStyle = BorderStyle.FixedSingle;
            AmountTxtBx.Dock = DockStyle.Right;
            AmountTxtBx.ForeColor = SystemColors.WindowText;
            AmountTxtBx.Location = new Point(713, 0);
            AmountTxtBx.Margin = new Padding(5, 4, 5, 4);
            AmountTxtBx.Name = "AmountTxtBx";
            AmountTxtBx.Size = new Size(155, 27);
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
            WithdrawAddSelect.Margin = new Padding(5, 4, 5, 4);
            WithdrawAddSelect.Name = "WithdrawAddSelect";
            WithdrawAddSelect.Size = new Size(188, 28);
            WithdrawAddSelect.TabIndex = 3;
            WithdrawAddSelect.SelectedIndexChanged += WithdrawAddSelect_SelectedIndexChanged;
            // 
            // EditBalanceLbl
            // 
            EditBalanceLbl.Anchor = AnchorStyles.None;
            EditBalanceLbl.AutoSize = true;
            EditBalanceLbl.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBalanceLbl.ForeColor = Color.White;
            EditBalanceLbl.Location = new Point(410, 362);
            EditBalanceLbl.Margin = new Padding(5, 0, 5, 0);
            EditBalanceLbl.Name = "EditBalanceLbl";
            EditBalanceLbl.Size = new Size(181, 23);
            EditBalanceLbl.TabIndex = 2;
            EditBalanceLbl.Text = "Move Money/ History";
            // 
            // ExpenseTypeLbl
            // 
            ExpenseTypeLbl.AutoSize = true;
            ExpenseTypeLbl.Dock = DockStyle.Left;
            ExpenseTypeLbl.ForeColor = Color.White;
            ExpenseTypeLbl.Location = new Point(188, 0);
            ExpenseTypeLbl.Margin = new Padding(2, 0, 2, 0);
            ExpenseTypeLbl.Name = "ExpenseTypeLbl";
            ExpenseTypeLbl.Size = new Size(101, 20);
            ExpenseTypeLbl.TabIndex = 10;
            ExpenseTypeLbl.Text = "Expense Type:";
            // 
            // BalanceTxtBx
            // 
            BalanceTxtBx.Anchor = AnchorStyles.None;
            BalanceTxtBx.BackColor = SystemColors.ActiveCaption;
            BalanceTxtBx.BorderStyle = BorderStyle.None;
            BalanceTxtBx.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BalanceTxtBx.Location = new Point(425, 209);
            BalanceTxtBx.Margin = new Padding(5, 4, 5, 4);
            BalanceTxtBx.Name = "BalanceTxtBx";
            BalanceTxtBx.Size = new Size(155, 23);
            BalanceTxtBx.TabIndex = 1;
            BalanceTxtBx.TextChanged += BalanceTxtBx_TextChanged;
            // 
            // SavingsProgressBar
            // 
            SavingsProgressBar.BackColor = SystemColors.ControlDarkDark;
            SavingsProgressBar.Dock = DockStyle.Fill;
            SavingsProgressBar.Location = new Point(0, 0);
            SavingsProgressBar.Margin = new Padding(5, 4, 5, 4);
            SavingsProgressBar.Maximum = 10000;
            SavingsProgressBar.Name = "SavingsProgressBar";
            SavingsProgressBar.Size = new Size(917, 70);
            SavingsProgressBar.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(SavingsProgressBar);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(987, 70);
            panel1.TabIndex = 12;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = SystemColors.Control;
            iconPictureBox1.Dock = DockStyle.Right;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 70;
            iconPictureBox1.Location = new Point(917, 0);
            iconPictureBox1.Margin = new Padding(3, 2, 3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(70, 70);
            iconPictureBox1.TabIndex = 10;
            iconPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(ExpenseTypeComboBox);
            panel2.Controls.Add(AmountLbl);
            panel2.Controls.Add(ExpenseTypeLbl);
            panel2.Controls.Add(WithdrawAddSelect);
            panel2.Controls.Add(AmountTxtBx);
            panel2.Controls.Add(ConfirmBttn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 396);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 30);
            panel2.TabIndex = 13;
            // 
            // ExpenseTypeComboBox
            // 
            ExpenseTypeComboBox.FormattingEnabled = true;
            ExpenseTypeComboBox.Location = new Point(289, 0);
            ExpenseTypeComboBox.Margin = new Padding(2, 2, 2, 2);
            ExpenseTypeComboBox.Name = "ExpenseTypeComboBox";
            ExpenseTypeComboBox.Size = new Size(354, 28);
            ExpenseTypeComboBox.TabIndex = 14;
            // 
            // BalanceLbl
            // 
            BalanceLbl.Anchor = AnchorStyles.None;
            BalanceLbl.AutoSize = true;
            BalanceLbl.ForeColor = Color.White;
            BalanceLbl.Location = new Point(448, 185);
            BalanceLbl.Margin = new Padding(5, 0, 5, 0);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(116, 20);
            BalanceLbl.TabIndex = 0;
            BalanceLbl.Text = "Current Balance:";
            // 
            // ExpenseScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BalanceTxtBx);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Transactions);
            Controls.Add(BalanceLbl);
            Controls.Add(EditBalanceLbl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpenseScreen";
            Size = new Size(987, 648);
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
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel panel2;
        private Label BalanceLbl;
        private ComboBox ExpenseTypeComboBox;
    }
}
