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
            ExpenseTypeComboBox = new ComboBox();
            BalanceLbl = new Label();
            Title = new Label();
            SuspendLayout();
            // 
            // Transactions
            // 
            Transactions.Anchor = AnchorStyles.None;
            Transactions.FormattingEnabled = true;
            Transactions.Location = new Point(401, 408);
            Transactions.Margin = new Padding(4);
            Transactions.Name = "Transactions";
            Transactions.Size = new Size(520, 264);
            Transactions.TabIndex = 7;
            // 
            // ConfirmBttn
            // 
            ConfirmBttn.Anchor = AnchorStyles.None;
            ConfirmBttn.BackColor = SystemColors.MenuHighlight;
            ConfirmBttn.FlatAppearance.BorderSize = 0;
            ConfirmBttn.FlatStyle = FlatStyle.Flat;
            ConfirmBttn.Location = new Point(892, 282);
            ConfirmBttn.Margin = new Padding(5);
            ConfirmBttn.Name = "ConfirmBttn";
            ConfirmBttn.Size = new Size(148, 45);
            ConfirmBttn.TabIndex = 6;
            ConfirmBttn.Text = "Confirm";
            ConfirmBttn.UseVisualStyleBackColor = false;
            ConfirmBttn.Click += ConfirmBttn_Click;
            // 
            // AmountLbl
            // 
            AmountLbl.Anchor = AnchorStyles.None;
            AmountLbl.AutoSize = true;
            AmountLbl.Location = new Point(598, 301);
            AmountLbl.Margin = new Padding(5, 0, 5, 0);
            AmountLbl.Name = "AmountLbl";
            AmountLbl.Size = new Size(65, 20);
            AmountLbl.TabIndex = 5;
            AmountLbl.Text = "Amount:";
            // 
            // AmountTxtBx
            // 
            AmountTxtBx.Anchor = AnchorStyles.None;
            AmountTxtBx.BorderStyle = BorderStyle.None;
            AmountTxtBx.Location = new Point(689, 301);
            AmountTxtBx.Margin = new Padding(5);
            AmountTxtBx.Name = "AmountTxtBx";
            AmountTxtBx.Size = new Size(193, 20);
            AmountTxtBx.TabIndex = 4;
            // 
            // WithdrawAddSelect
            // 
            WithdrawAddSelect.Anchor = AnchorStyles.None;
            WithdrawAddSelect.FlatStyle = FlatStyle.Flat;
            WithdrawAddSelect.FormattingEnabled = true;
            WithdrawAddSelect.Items.AddRange(new object[] { "Add Expense", "Deposit" });
            WithdrawAddSelect.Location = new Point(353, 291);
            WithdrawAddSelect.Margin = new Padding(5);
            WithdrawAddSelect.Name = "WithdrawAddSelect";
            WithdrawAddSelect.Size = new Size(234, 28);
            WithdrawAddSelect.TabIndex = 3;
            WithdrawAddSelect.SelectedIndexChanged += WithdrawAddSelect_SelectedIndexChanged;
            // 
            // EditBalanceLbl
            // 
            EditBalanceLbl.Anchor = AnchorStyles.None;
            EditBalanceLbl.AutoSize = true;
            EditBalanceLbl.Location = new Point(610, 235);
            EditBalanceLbl.Margin = new Padding(5, 0, 5, 0);
            EditBalanceLbl.Name = "EditBalanceLbl";
            EditBalanceLbl.Size = new Size(95, 20);
            EditBalanceLbl.TabIndex = 2;
            EditBalanceLbl.Text = "Move Money";
            // 
            // ExpenseTypeLbl
            // 
            ExpenseTypeLbl.Anchor = AnchorStyles.None;
            ExpenseTypeLbl.AutoSize = true;
            ExpenseTypeLbl.Location = new Point(539, 356);
            ExpenseTypeLbl.Name = "ExpenseTypeLbl";
            ExpenseTypeLbl.Size = new Size(101, 20);
            ExpenseTypeLbl.TabIndex = 10;
            ExpenseTypeLbl.Text = "Expense Type:";
            ExpenseTypeLbl.Click += ExpenseTypeLbl_Click;
            // 
            // BalanceTxtBx
            // 
            BalanceTxtBx.Anchor = AnchorStyles.None;
            BalanceTxtBx.BorderStyle = BorderStyle.None;
            BalanceTxtBx.Location = new Point(635, 190);
            BalanceTxtBx.Margin = new Padding(5);
            BalanceTxtBx.Name = "BalanceTxtBx";
            BalanceTxtBx.Size = new Size(193, 20);
            BalanceTxtBx.TabIndex = 1;
            BalanceTxtBx.TextChanged += BalanceTxtBx_TextChanged;
            // 
            // ExpenseTypeComboBox
            // 
            ExpenseTypeComboBox.Anchor = AnchorStyles.None;
            ExpenseTypeComboBox.FlatStyle = FlatStyle.Flat;
            ExpenseTypeComboBox.FormattingEnabled = true;
            ExpenseTypeComboBox.Location = new Point(663, 353);
            ExpenseTypeComboBox.Margin = new Padding(2);
            ExpenseTypeComboBox.Name = "ExpenseTypeComboBox";
            ExpenseTypeComboBox.Size = new Size(125, 28);
            ExpenseTypeComboBox.TabIndex = 14;
            // 
            // BalanceLbl
            // 
            BalanceLbl.Anchor = AnchorStyles.None;
            BalanceLbl.AutoSize = true;
            BalanceLbl.Location = new Point(498, 193);
            BalanceLbl.Margin = new Padding(5, 0, 5, 0);
            BalanceLbl.Name = "BalanceLbl";
            BalanceLbl.Size = new Size(116, 20);
            BalanceLbl.TabIndex = 0;
            BalanceLbl.Text = "Current Balance:";
            BalanceLbl.Click += BalanceLbl_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F);
            Title.Location = new Point(571, 110);
            Title.Margin = new Padding(2, 0, 2, 0);
            Title.Name = "Title";
            Title.Size = new Size(184, 54);
            Title.TabIndex = 16;
            Title.Text = "Expenses";
            // 
            // ExpenseScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Title);
            Controls.Add(WithdrawAddSelect);
            Controls.Add(ExpenseTypeLbl);
            Controls.Add(ExpenseTypeComboBox);
            Controls.Add(AmountTxtBx);
            Controls.Add(ConfirmBttn);
            Controls.Add(AmountLbl);
            Controls.Add(BalanceTxtBx);
            Controls.Add(BalanceLbl);
            Controls.Add(EditBalanceLbl);
            Controls.Add(Transactions);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ExpenseScreen";
            Size = new Size(1242, 845);
            Load += MainScreen_Load;
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
        private Label BalanceLbl;
        private ComboBox ExpenseTypeComboBox;
        private Label Title;
    }
}
