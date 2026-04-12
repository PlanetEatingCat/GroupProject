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
            TitlePanel = new Panel();
            ToolsPanel = new Panel();
            TitlePanel.SuspendLayout();
            ToolsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SubscriptionName
            // 
            SubscriptionName.Anchor = AnchorStyles.None;
            SubscriptionName.BackColor = SystemColors.GradientInactiveCaption;
            SubscriptionName.BorderStyle = BorderStyle.FixedSingle;
            SubscriptionName.Location = new Point(96, 3);
            SubscriptionName.Margin = new Padding(2);
            SubscriptionName.Name = "SubscriptionName";
            SubscriptionName.Size = new Size(121, 27);
            SubscriptionName.TabIndex = 0;
            // 
            // SubNameLabel
            // 
            SubNameLabel.Anchor = AnchorStyles.None;
            SubNameLabel.AutoSize = true;
            SubNameLabel.Location = new Point(131, 30);
            SubNameLabel.Margin = new Padding(2, 0, 2, 0);
            SubNameLabel.Name = "SubNameLabel";
            SubNameLabel.Size = new Size(49, 20);
            SubNameLabel.TabIndex = 1;
            SubNameLabel.Text = "Name";
            // 
            // PayAmount
            // 
            PayAmount.Anchor = AnchorStyles.None;
            PayAmount.AutoSize = true;
            PayAmount.Location = new Point(259, 36);
            PayAmount.Margin = new Padding(2, 0, 2, 0);
            PayAmount.Name = "PayAmount";
            PayAmount.Size = new Size(62, 20);
            PayAmount.TabIndex = 3;
            PayAmount.Text = "Amount";
            // 
            // SubscriptionAmount
            // 
            SubscriptionAmount.Anchor = AnchorStyles.None;
            SubscriptionAmount.BackColor = SystemColors.GradientInactiveCaption;
            SubscriptionAmount.BorderStyle = BorderStyle.FixedSingle;
            SubscriptionAmount.Location = new Point(231, 2);
            SubscriptionAmount.Margin = new Padding(2);
            SubscriptionAmount.Name = "SubscriptionAmount";
            SubscriptionAmount.Size = new Size(121, 27);
            SubscriptionAmount.TabIndex = 2;
            // 
            // PaymentFrequency
            // 
            PaymentFrequency.Anchor = AnchorStyles.None;
            PaymentFrequency.AutoSize = true;
            PaymentFrequency.Location = new Point(397, 30);
            PaymentFrequency.Margin = new Padding(2, 0, 2, 0);
            PaymentFrequency.Name = "PaymentFrequency";
            PaymentFrequency.Size = new Size(76, 20);
            PaymentFrequency.TabIndex = 5;
            PaymentFrequency.Text = "Frequency";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 24F);
            Title.Location = new Point(115, 4);
            Title.Margin = new Padding(2, 0, 2, 0);
            Title.Name = "Title";
            Title.Size = new Size(413, 54);
            Title.TabIndex = 6;
            Title.Text = "Subscription Manager";
            // 
            // ListOfSubscriptions
            // 
            ListOfSubscriptions.Anchor = AnchorStyles.None;
            ListOfSubscriptions.BackColor = SystemColors.GradientInactiveCaption;
            ListOfSubscriptions.BorderStyle = BorderStyle.None;
            ListOfSubscriptions.FormattingEnabled = true;
            ListOfSubscriptions.Location = new Point(112, 111);
            ListOfSubscriptions.Margin = new Padding(2);
            ListOfSubscriptions.Name = "ListOfSubscriptions";
            ListOfSubscriptions.Size = new Size(394, 140);
            ListOfSubscriptions.TabIndex = 7;
            ListOfSubscriptions.SelectedIndexChanged += ListOfSubscriptions_SelectedIndexChanged;
            // 
            // AddSubscription
            // 
            AddSubscription.Anchor = AnchorStyles.None;
            AddSubscription.BackColor = Color.White;
            AddSubscription.FlatAppearance.BorderSize = 0;
            AddSubscription.FlatStyle = FlatStyle.Flat;
            AddSubscription.Location = new Point(218, 65);
            AddSubscription.Margin = new Padding(2);
            AddSubscription.Name = "AddSubscription";
            AddSubscription.Size = new Size(168, 27);
            AddSubscription.TabIndex = 8;
            AddSubscription.Text = "Add Subscription";
            AddSubscription.UseVisualStyleBackColor = false;
            AddSubscription.Click += AddSubscription_Click;
            // 
            // FrequencyDropDown
            // 
            FrequencyDropDown.Anchor = AnchorStyles.None;
            FrequencyDropDown.BackColor = SystemColors.GradientInactiveCaption;
            FrequencyDropDown.FormattingEnabled = true;
            FrequencyDropDown.Items.AddRange(new object[] { "Weekly", "Monthly", "Quarterly", "Annually" });
            FrequencyDropDown.Location = new Point(371, 2);
            FrequencyDropDown.Margin = new Padding(2);
            FrequencyDropDown.Name = "FrequencyDropDown";
            FrequencyDropDown.Size = new Size(146, 28);
            FrequencyDropDown.TabIndex = 9;
            // 
            // SubscriptionRemover
            // 
            SubscriptionRemover.Anchor = AnchorStyles.None;
            SubscriptionRemover.BackColor = Color.White;
            SubscriptionRemover.FlatAppearance.BorderSize = 0;
            SubscriptionRemover.FlatStyle = FlatStyle.Flat;
            SubscriptionRemover.Location = new Point(115, 306);
            SubscriptionRemover.Margin = new Padding(2);
            SubscriptionRemover.Name = "SubscriptionRemover";
            SubscriptionRemover.Size = new Size(114, 58);
            SubscriptionRemover.TabIndex = 10;
            SubscriptionRemover.Text = "Remove Subscription";
            SubscriptionRemover.UseVisualStyleBackColor = false;
            SubscriptionRemover.Click += SubscriptionRemover_Click;
            // 
            // EditSubscription
            // 
            EditSubscription.Anchor = AnchorStyles.None;
            EditSubscription.BackColor = Color.White;
            EditSubscription.FlatAppearance.BorderSize = 0;
            EditSubscription.FlatStyle = FlatStyle.Flat;
            EditSubscription.Location = new Point(392, 306);
            EditSubscription.Margin = new Padding(2);
            EditSubscription.Name = "EditSubscription";
            EditSubscription.Size = new Size(114, 58);
            EditSubscription.TabIndex = 11;
            EditSubscription.Text = "Edit Subscription";
            EditSubscription.UseVisualStyleBackColor = false;
            EditSubscription.Click += EditSubscription_Click;
            // 
            // TitlePanel
            // 
            TitlePanel.Anchor = AnchorStyles.Top;
            TitlePanel.BackColor = SystemColors.ActiveCaption;
            TitlePanel.Controls.Add(Title);
            TitlePanel.Location = new Point(101, 15);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(628, 77);
            TitlePanel.TabIndex = 12;
            // 
            // ToolsPanel
            // 
            ToolsPanel.Anchor = AnchorStyles.None;
            ToolsPanel.BackColor = SystemColors.ActiveCaption;
            ToolsPanel.Controls.Add(EditSubscription);
            ToolsPanel.Controls.Add(SubscriptionRemover);
            ToolsPanel.Controls.Add(FrequencyDropDown);
            ToolsPanel.Controls.Add(AddSubscription);
            ToolsPanel.Controls.Add(ListOfSubscriptions);
            ToolsPanel.Controls.Add(PaymentFrequency);
            ToolsPanel.Controls.Add(PayAmount);
            ToolsPanel.Controls.Add(SubscriptionAmount);
            ToolsPanel.Controls.Add(SubNameLabel);
            ToolsPanel.Controls.Add(SubscriptionName);
            ToolsPanel.Location = new Point(101, 109);
            ToolsPanel.Name = "ToolsPanel";
            ToolsPanel.Size = new Size(628, 372);
            ToolsPanel.TabIndex = 13;
            // 
            // SubscriptionScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            Controls.Add(ToolsPanel);
            Controls.Add(TitlePanel);
            Margin = new Padding(2);
            Name = "SubscriptionScreen";
            Size = new Size(839, 499);
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            ToolsPanel.ResumeLayout(false);
            ToolsPanel.PerformLayout();
            ResumeLayout(false);
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
        private Panel TitlePanel;
        private Panel ToolsPanel;
    }
}
