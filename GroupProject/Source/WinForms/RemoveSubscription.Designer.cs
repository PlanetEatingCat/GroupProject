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
            SubRemoveText = new TextBox();
            ConfirmRemove = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // SubRemoveText
            // 
            SubRemoveText.Location = new Point(300, 115);
            SubRemoveText.Name = "SubRemoveText";
            SubRemoveText.Size = new Size(150, 31);
            SubRemoveText.TabIndex = 0;
            // 
            // ConfirmRemove
            // 
            ConfirmRemove.Location = new Point(318, 152);
            ConfirmRemove.Name = "ConfirmRemove";
            ConfirmRemove.Size = new Size(110, 69);
            ConfirmRemove.TabIndex = 1;
            ConfirmRemove.Text = "Confirm Remove";
            ConfirmRemove.UseVisualStyleBackColor = true;
            ConfirmRemove.Click += ConfirmRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(186, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 54);
            label1.TabIndex = 2;
            label1.Text = "Remove Subscription";
            // 
            // RemoveSubscription
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(ConfirmRemove);
            Controls.Add(SubRemoveText);
            Name = "RemoveSubscription";
            Text = "RemoveSubscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubRemoveText;
        private Button ConfirmRemove;
        private Label label1;
    }
}