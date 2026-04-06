namespace BudgetPlanner
{
    partial class SubscriptionScreen
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
            SubscriptionName = new TextBox();
            SubNameLabel = new Label();
            PayAmount = new Label();
            SubscriptionAmount = new TextBox();
            PaymentFrequency = new Label();
            Title = new Label();
            ListOfSubscriptions = new ListBox();
            AddSubscription = new Button();
            FrequencyDropDown = new ComboBox();
            SubscriptionRemover = new Button();
            EditSubscription = new Button();
            SuspendLayout();
            // 
            // SubscriptionName
            // 
            SubscriptionName.Location = new Point(231, 145);
            SubscriptionName.Name = "SubscriptionName";
            SubscriptionName.Size = new Size(150, 31);
            SubscriptionName.TabIndex = 0;
            // 
            // SubNameLabel
            // 
            SubNameLabel.AutoSize = true;
            SubNameLabel.Location = new Point(275, 179);
            SubNameLabel.Name = "SubNameLabel";
            SubNameLabel.Size = new Size(59, 25);
            SubNameLabel.TabIndex = 1;
            SubNameLabel.Text = "Name";
            // 
            // PayAmount
            // 
            PayAmount.AutoSize = true;
            PayAmount.Location = new Point(471, 179);
            PayAmount.Name = "PayAmount";
            PayAmount.Size = new Size(77, 25);
            PayAmount.TabIndex = 3;
            PayAmount.Text = "Amount";
            // 
            // SubscriptionAmount
            // 
            SubscriptionAmount.Location = new Point(436, 145);
            SubscriptionAmount.Name = "SubscriptionAmount";
            SubscriptionAmount.Size = new Size(150, 31);
            SubscriptionAmount.TabIndex = 2;
            // 
            // PaymentFrequency
            // 
            PaymentFrequency.AutoSize = true;
            PaymentFrequency.Location = new Point(670, 179);
            PaymentFrequency.Name = "PaymentFrequency";
            PaymentFrequency.Size = new Size(93, 25);
            PaymentFrequency.TabIndex = 5;
            PaymentFrequency.Text = "Frequency";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F);
            Title.Location = new Point(271, 25);
            Title.Name = "Title";
            Title.Size = new Size(492, 65);
            Title.TabIndex = 6;
            Title.Text = "Subscription Manager";
            // 
            // ListOfSubscriptions
            // 
            ListOfSubscriptions.FormattingEnabled = true;
            ListOfSubscriptions.ItemHeight = 25;
            ListOfSubscriptions.Location = new Point(271, 275);
            ListOfSubscriptions.Name = "ListOfSubscriptions";
            ListOfSubscriptions.Size = new Size(492, 179);
            ListOfSubscriptions.TabIndex = 7;
            // 
            // AddSubscription
            // 
            AddSubscription.Location = new Point(404, 217);
            AddSubscription.Name = "AddSubscription";
            AddSubscription.Size = new Size(210, 34);
            AddSubscription.TabIndex = 8;
            AddSubscription.Text = "Add Subscription";
            AddSubscription.UseVisualStyleBackColor = true;
            AddSubscription.Click += AddSubscription_Click;
            // 
            // FrequencyDropDown
            // 
            FrequencyDropDown.FormattingEnabled = true;
            FrequencyDropDown.Items.AddRange(new object[] { "Weekly", "Monthly", "Quarterly", "Annually" });
            FrequencyDropDown.Location = new Point(631, 145);
            FrequencyDropDown.Name = "FrequencyDropDown";
            FrequencyDropDown.Size = new Size(182, 33);
            FrequencyDropDown.TabIndex = 9;
            // 
            // SubscriptionRemover
            // 
            SubscriptionRemover.Location = new Point(275, 519);
            SubscriptionRemover.Name = "SubscriptionRemover";
            SubscriptionRemover.Size = new Size(142, 72);
            SubscriptionRemover.TabIndex = 10;
            SubscriptionRemover.Text = "Remove Subscription";
            SubscriptionRemover.UseVisualStyleBackColor = true;
            SubscriptionRemover.Click += SubscriptionRemover_Click;
            // 
            // EditSubscription
            // 
            EditSubscription.Location = new Point(621, 519);
            EditSubscription.Name = "EditSubscription";
            EditSubscription.Size = new Size(142, 72);
            EditSubscription.TabIndex = 11;
            EditSubscription.Text = "Edit Subscription";
            EditSubscription.UseVisualStyleBackColor = true;
            // 
            // SubscriptionManagerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(EditSubscription);
            Controls.Add(SubscriptionRemover);
            Controls.Add(FrequencyDropDown);
            Controls.Add(AddSubscription);
            Controls.Add(ListOfSubscriptions);
            Controls.Add(Title);
            Controls.Add(PaymentFrequency);
            Controls.Add(PayAmount);
            Controls.Add(SubscriptionAmount);
            Controls.Add(SubNameLabel);
            Controls.Add(SubscriptionName);
            Name = "SubscriptionManagerForm";
            Size = new Size(1049, 624);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubscriptionName;
        private Label SubNameLabel;
        private Label PayAmount;
        private TextBox SubscriptionAmount;
        private Label PaymentFrequency;
        private Label Title;
        private ListBox ListOfSubscriptions;
        private Button AddSubscription;
        private ComboBox FrequencyDropDown;
        private Button SubscriptionRemover;
        private Button EditSubscription;
    }
}
