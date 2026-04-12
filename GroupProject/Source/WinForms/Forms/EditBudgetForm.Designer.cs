namespace BudgetPlanner
{
    partial class EditBudgetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBudgetForm));
            NameInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CategoryInput = new TextBox();
            label3 = new Label();
            LimitInput = new TextBox();
            DoneButton = new Button();
            Title = new Label();
            BaseMainPanel.SuspendLayout();
            TitleBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(246, 0);
            RightMenuBarPanel.Size = new Size(0, 66);
            // 
            // MinButton
            // 
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(246, 0);
            // 
            // MaxButton
            // 
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(302, 0);
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(358, 0);
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Size = new Size(0, 66);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.Controls.Add(DoneButton);
            BaseMainPanel.Controls.Add(label3);
            BaseMainPanel.Controls.Add(LimitInput);
            BaseMainPanel.Controls.Add(label2);
            BaseMainPanel.Controls.Add(CategoryInput);
            BaseMainPanel.Controls.Add(label1);
            BaseMainPanel.Controls.Add(NameInput);
            BaseMainPanel.Location = new Point(2, 68);
            BaseMainPanel.Size = new Size(414, 286);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.Controls.Add(Title);
            TitleBarPanel.Location = new Point(2, 2);
            TitleBarPanel.Size = new Size(414, 66);
            TitleBarPanel.Controls.SetChildIndex(CloseButton, 0);
            TitleBarPanel.Controls.SetChildIndex(MaxButton, 0);
            TitleBarPanel.Controls.SetChildIndex(LeftMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(MinButton, 0);
            TitleBarPanel.Controls.SetChildIndex(RightMenuBarPanel, 0);
            TitleBarPanel.Controls.SetChildIndex(Title, 0);
            // 
            // NameInput
            // 
            NameInput.BorderStyle = BorderStyle.None;
            NameInput.Location = new Point(169, 21);
            NameInput.Name = "NameInput";
            NameInput.Size = new Size(125, 20);
            NameInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 24);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 3;
            label2.Text = "Category";
            // 
            // CategoryInput
            // 
            CategoryInput.BorderStyle = BorderStyle.None;
            CategoryInput.Location = new Point(169, 75);
            CategoryInput.Name = "CategoryInput";
            CategoryInput.Size = new Size(125, 20);
            CategoryInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 131);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 5;
            label3.Text = "Spending Limit $";
            // 
            // LimitInput
            // 
            LimitInput.BorderStyle = BorderStyle.None;
            LimitInput.Location = new Point(169, 128);
            LimitInput.Name = "LimitInput";
            LimitInput.Size = new Size(125, 20);
            LimitInput.TabIndex = 4;
            // 
            // DoneButton
            // 
            DoneButton.BackColor = SystemColors.MenuHighlight;
            DoneButton.FlatAppearance.BorderSize = 0;
            DoneButton.FlatStyle = FlatStyle.Flat;
            DoneButton.Location = new Point(159, 198);
            DoneButton.Name = "DoneButton";
            DoneButton.Size = new Size(152, 53);
            DoneButton.TabIndex = 6;
            DoneButton.Text = "Done";
            DoneButton.UseVisualStyleBackColor = false;
            DoneButton.Click += button1_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(18, 14);
            Title.Name = "Title";
            Title.Size = new Size(135, 31);
            Title.TabIndex = 8;
            Title.Text = "Edit Budget";
            // 
            // EditBudgetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 356);
            Location = new Point(0, 0);
            Name = "EditBudgetForm";
            Padding = new Padding(2);
            Text = "AddBudgetForm";
            BaseMainPanel.ResumeLayout(false);
            BaseMainPanel.PerformLayout();
            TitleBarPanel.ResumeLayout(false);
            TitleBarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox NameInput;
        private Button DoneButton;
        private Label label3;
        private TextBox LimitInput;
        private Label label2;
        private TextBox CategoryInput;
        private Label label1;
        private Label Title;
    }
}