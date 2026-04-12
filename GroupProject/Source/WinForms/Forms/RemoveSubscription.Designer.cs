namespace BudgetPlanner
{
    partial class RemoveSubscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveSubscription));
            SubRemoveText = new TextBox();
            ConfirmRemove = new Button();
            label1 = new Label();
            BaseMainPanel.SuspendLayout();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(458, 0);
            RightMenuBarPanel.Size = new Size(10, 66);
            // 
            // MinButton
            // 
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(468, 0);
            // 
            // MaxButton
            // 
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(524, 0);
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(580, 0);
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Size = new Size(10, 66);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.Controls.Add(ConfirmRemove);
            BaseMainPanel.Controls.Add(SubRemoveText);
            BaseMainPanel.Location = new Point(2, 68);
            BaseMainPanel.Size = new Size(636, 290);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.Controls.Add(label1);
            TitleBarPanel.Location = new Point(2, 2);
            TitleBarPanel.Size = new Size(636, 66);
            TitleBarPanel.Controls.SetChildIndex(CloseButton, 0);
            TitleBarPanel.Controls.SetChildIndex(MaxButton, 0);
            TitleBarPanel.Controls.SetChildIndex(LeftMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(MinButton, 0);
            TitleBarPanel.Controls.SetChildIndex(RightMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(label1, 0);
            // 
            // SubRemoveText
            // 
            SubRemoveText.BorderStyle = BorderStyle.None;
            SubRemoveText.Location = new Point(240, 92);
            SubRemoveText.Margin = new Padding(2);
            SubRemoveText.Name = "SubRemoveText";
            SubRemoveText.Size = new Size(121, 20);
            SubRemoveText.TabIndex = 0;
            // 
            // ConfirmRemove
            // 
            ConfirmRemove.BackColor = SystemColors.MenuHighlight;
            ConfirmRemove.FlatAppearance.BorderSize = 0;
            ConfirmRemove.FlatStyle = FlatStyle.Flat;
            ConfirmRemove.Location = new Point(254, 122);
            ConfirmRemove.Margin = new Padding(2);
            ConfirmRemove.Name = "ConfirmRemove";
            ConfirmRemove.Size = new Size(88, 55);
            ConfirmRemove.TabIndex = 1;
            ConfirmRemove.Text = "Confirm Remove";
            ConfirmRemove.UseVisualStyleBackColor = false;
            ConfirmRemove.Click += ConfirmRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(26, 3);
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
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(640, 360);
            Location = new Point(0, 0);
            Name = "RemoveSubscription";
            Padding = new Padding(2);
            Text = "RemoveSubscription";
            FormClosed += RemoveSubscription_FormClosed;
            BaseMainPanel.ResumeLayout(false);
            BaseMainPanel.PerformLayout();
            TitleBarPanel.ResumeLayout(false);
            TitleBarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox SubRemoveText;
        private Button ConfirmRemove;
        private Label label1;
    }
}