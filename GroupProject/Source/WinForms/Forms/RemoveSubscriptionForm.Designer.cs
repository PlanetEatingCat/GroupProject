namespace BudgetPlanner
{
    partial class RemoveSubscriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveSubscriptionForm));
            SubRemoveText = new TextBox();
            ConfirmRemove = new Button();
            label1 = new Label();
            BaseMainPanel.SuspendLayout();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(638, 0);
            RightMenuBarPanel.Size = new Size(36, 66);
            // 
            // MinButton
            // 
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(674, 0);
            // 
            // MaxButton
            // 
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(730, 0);
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(786, 0);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.Controls.Add(ConfirmRemove);
            BaseMainPanel.Location = new Point(2, 68);
            BaseMainPanel.Size = new Size(842, 372);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = SystemColors.MenuHighlight;
            TitleBarPanel.Controls.Add(label1);
            TitleBarPanel.Location = new Point(2, 2);
            TitleBarPanel.Margin = new Padding(0);
            TitleBarPanel.Size = new Size(842, 66);
            TitleBarPanel.Controls.SetChildIndex(LeftMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(CloseButton, 0);
            TitleBarPanel.Controls.SetChildIndex(MaxButton, 0);
            TitleBarPanel.Controls.SetChildIndex(MinButton, 0);
            TitleBarPanel.Controls.SetChildIndex(RightMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(label1, 0);
            // 
            // SubRemoveText
            // 
            SubRemoveText.Location = new Point(345, 146);
            SubRemoveText.Margin = new Padding(2);
            SubRemoveText.Name = "SubRemoveText";
            SubRemoveText.Size = new Size(121, 27);
            SubRemoveText.TabIndex = 0;
            // 
            // ConfirmRemove
            // 
            ConfirmRemove.Location = new Point(360, 175);
            ConfirmRemove.Margin = new Padding(2);
            ConfirmRemove.Name = "ConfirmRemove";
            ConfirmRemove.Size = new Size(88, 55);
            ConfirmRemove.TabIndex = 1;
            ConfirmRemove.Text = "Confirm Remove";
            ConfirmRemove.UseVisualStyleBackColor = true;
            ConfirmRemove.Click += ConfirmRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(270, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(335, 46);
            label1.TabIndex = 2;
            label1.Text = "Remove Subscription";
            // 
            // RemoveSubscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(846, 442);
            Controls.Add(SubRemoveText);
            Location = new Point(0, 0);
            Name = "RemoveSubscription";
            Padding = new Padding(2);
            Text = "RemoveSubscription";
            Controls.SetChildIndex(TitleBarPanel, 0);
            Controls.SetChildIndex(BaseMainPanel, 0);
            Controls.SetChildIndex(SubRemoveText, 0);
            BaseMainPanel.ResumeLayout(false);
            TitleBarPanel.ResumeLayout(false);
            TitleBarPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubRemoveText;
        private Button ConfirmRemove;
        private Label label1;

    }
}