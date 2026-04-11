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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSubscriptionForm));
            SubName = new TextBox();
            OwedAmount = new TextBox();
            Name = new Label();
            Amount = new Label();
            Freq = new Label();
            Title = new Label();
            EditConfirm = new Button();
            FreqDropDown = new ComboBox();
            TitleLabel = new Label();
            BaseMainPanel.SuspendLayout();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(586, 0);
            RightMenuBarPanel.Size = new Size(0, 82);
            // 
            // MinButton
            // 
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(586, 0);
            // 
            // MaxButton
            // 
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(656, 0);
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(726, 0);
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Size = new Size(0, 82);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.Controls.Add(Name);
            BaseMainPanel.Controls.Add(SubName);
            BaseMainPanel.Controls.Add(Freq);
            BaseMainPanel.Controls.Add(OwedAmount);
            BaseMainPanel.Controls.Add(Amount);
            BaseMainPanel.Controls.Add(EditConfirm);
            BaseMainPanel.Controls.Add(FreqDropDown);
            BaseMainPanel.Size = new Size(796, 364);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.Controls.Add(TitleLabel);
            TitleBarPanel.Size = new Size(796, 82);
            TitleBarPanel.Controls.SetChildIndex(CloseButton, 0);
            TitleBarPanel.Controls.SetChildIndex(MaxButton, 0);
            TitleBarPanel.Controls.SetChildIndex(LeftMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(MinButton, 0);
            TitleBarPanel.Controls.SetChildIndex(RightMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(TitleLabel, 0);
            // 
            // SubName
            // 
            SubName.BorderStyle = BorderStyle.None;
            SubName.Location = new Point(96, 73);
            SubName.Name = "SubName";
            SubName.Size = new Size(150, 24);
            SubName.TabIndex = 0;
            // 
            // OwedAmount
            // 
            OwedAmount.BorderStyle = BorderStyle.None;
            OwedAmount.Location = new Point(314, 73);
            OwedAmount.Name = "OwedAmount";
            OwedAmount.Size = new Size(150, 24);
            OwedAmount.TabIndex = 1;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.BackColor = SystemColors.GradientActiveCaption;
            Name.Location = new Point(127, 107);
            Name.Name = "Name";
            Name.Size = new Size(59, 25);
            Name.TabIndex = 3;
            Name.Text = "Name";
            // 
            // Amount
            // 
            Amount.AutoSize = true;
            Amount.BackColor = SystemColors.GradientActiveCaption;
            Amount.Location = new Point(344, 107);
            Amount.Name = "Amount";
            Amount.Size = new Size(77, 25);
            Amount.TabIndex = 4;
            Amount.Text = "Amount";
            // 
            // Freq
            // 
            Freq.AutoSize = true;
            Freq.BackColor = SystemColors.GradientActiveCaption;
            Freq.Location = new Point(553, 107);
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
            EditConfirm.BackColor = Color.White;
            EditConfirm.FlatAppearance.BorderSize = 0;
            EditConfirm.FlatStyle = FlatStyle.Flat;
            EditConfirm.Location = new Point(333, 156);
            EditConfirm.Name = "EditConfirm";
            EditConfirm.Size = new Size(112, 64);
            EditConfirm.TabIndex = 7;
            EditConfirm.Text = "Confirm Edit";
            EditConfirm.UseVisualStyleBackColor = false;
            EditConfirm.Click += EditConfirm_Click;
            // 
            // FreqDropDown
            // 
            FreqDropDown.FlatStyle = FlatStyle.Flat;
            FreqDropDown.FormattingEnabled = true;
            FreqDropDown.Items.AddRange(new object[] { "Weekly", "Monthly", "Quarterly", "Annually" });
            FreqDropDown.Location = new Point(527, 73);
            FreqDropDown.Name = "FreqDropDown";
            FreqDropDown.Size = new Size(182, 33);
            FreqDropDown.TabIndex = 8;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TitleLabel.Location = new Point(212, 6);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(323, 54);
            TitleLabel.TabIndex = 8;
            TitleLabel.Text = "Edit Subscription";
            // 
            // EditSubscriptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Location = new Point(0, 0);
          //  Name = "EditSubscriptionForm";
            Text = "EditSubscriptionForm";
            FormClosed += EditSubscriptionForm_FormClosed;
            Load += EditSubscriptionForm_Load;
            Controls.SetChildIndex(Title, 0);
            Controls.SetChildIndex(TitleBarPanel, 0);
            Controls.SetChildIndex(BaseMainPanel, 0);
            BaseMainPanel.ResumeLayout(false);
            BaseMainPanel.PerformLayout();
            TitleBarPanel.ResumeLayout(false);
            TitleBarPanel.PerformLayout();
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
        private Label TitleLabel;
    }
}