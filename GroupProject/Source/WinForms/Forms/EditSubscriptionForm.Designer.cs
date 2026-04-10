namespace BudgetPlanner
{
    partial class EditSubscriptionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubName = new TextBox();
            OwedAmount = new TextBox();
            Name = new Label();
            Amount = new Label();
            Freq = new Label();
            Title = new Label();
            EditConfirm = new Button();
            FreqDropDown = new ComboBox();
            SuspendLayout();
            // 
            // SubName
            // 
            SubName.Location = new Point(67, 157);
            SubName.Name = "SubName";
            SubName.Size = new Size(150, 31);
            SubName.TabIndex = 0;
            // 
            // OwedAmount
            // 
            OwedAmount.Location = new Point(285, 157);
            OwedAmount.Name = "OwedAmount";
            OwedAmount.Size = new Size(150, 31);
            OwedAmount.TabIndex = 1;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(111, 191);
            Name.Name = "Name";
            Name.Size = new Size(59, 25);
            Name.TabIndex = 3;
            Name.Text = "Name";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.Location = new Point(328, 191);
            Amount.Name = "Amount";
            Amount.Size = new Size(77, 25);
            Amount.TabIndex = 4;
            Amount.Text = "Amount";
            // 
            // Freq
            // 
            Freq.AutoSize = true;
            Freq.Location = new Point(537, 191);
            Freq.Name = "Freq";
            Freq.Size = new Size(93, 25);
            Freq.TabIndex = 5;
            Freq.Text = "Frequency";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F);
            Title.Location = new Point(214, 26);
            Title.Name = "Title";
            Title.Size = new Size(323, 54);
            Title.TabIndex = 6;
            Title.Text = "Edit Subscription";
            // 
            // EditConfirm
            // 
            EditConfirm.Location = new Point(304, 240);
            EditConfirm.Name = "EditConfirm";
            EditConfirm.Size = new Size(112, 64);
            EditConfirm.TabIndex = 7;
            EditConfirm.Text = "Confirm Edit";
            EditConfirm.UseVisualStyleBackColor = true;
            EditConfirm.Click += EditConfirm_Click;
            // 
            // FreqDropDown
            // 
            FreqDropDown.FormattingEnabled = true;
            FreqDropDown.Items.AddRange(new object[] { "Weekly", "Monthly", "Quarterly", "Annually" });
            FreqDropDown.Location = new Point(498, 157);
            FreqDropDown.Name = "FreqDropDown";
            FreqDropDown.Size = new Size(182, 33);
            FreqDropDown.TabIndex = 8;
            // 
            // EditSubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FreqDropDown);
            Controls.Add(EditConfirm);
            Controls.Add(Title);
            Controls.Add(Freq);
            Controls.Add(Amount);
            Controls.Add(Name);
            Controls.Add(OwedAmount);
            Controls.Add(SubName);
            //Name = "EditSubscriptionForm";
            Text = "EditSubscriptionForm";
            FormClosed += EditSubscriptionForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubName;
        private TextBox OwedAmount;
        private Label Name;
        private Label Amount;
        private Label Freq;
        private Label Title;
        private Button EditConfirm;
        private ComboBox FreqDropDown;
    }
}