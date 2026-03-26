namespace BudgetPlanner
{
    partial class BudgetPlannerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetPlannerForm));
            MainPanel = new Panel();
            MessagePanel = new Panel();
            Message = new Label();
            MessageIcon = new PictureBox();
            TitleBarPanel = new Panel();
            RightMenuBarPanel = new Panel();
            MinButton = new Button();
            MaxButton = new Button();
            CloseButton = new Button();
            MenuPanel = new Panel();
            ExpensesMenuButton = new FontAwesome.Sharp.IconButton();
            CardMenuButton = new FontAwesome.Sharp.IconButton();
            IncomeMenuButton = new FontAwesome.Sharp.IconButton();
            GoalsMenuButton = new FontAwesome.Sharp.IconButton();
            SubscriptionMenuButton = new FontAwesome.Sharp.IconButton();
            CalendarMenuButton = new FontAwesome.Sharp.IconButton();
            HomeMenuButton = new FontAwesome.Sharp.IconButton();
            LogoLable = new Label();
            MenuButton = new FontAwesome.Sharp.IconButton();
            MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).BeginInit();
            TitleBarPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.GradientActiveCaption;
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(287, 82);
            MainPanel.Margin = new Padding(4, 3, 4, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1159, 783);
            MainPanel.TabIndex = 0;
            MainPanel.Paint += MainPanel_Paint;
            MainPanel.Resize += MainPanel_Resize;
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.LightSkyBlue;
            MessagePanel.Controls.Add(Message);
            MessagePanel.Controls.Add(MessageIcon);
            MessagePanel.Dock = DockStyle.Bottom;
            MessagePanel.Location = new Point(0, 865);
            MessagePanel.Margin = new Padding(4, 3, 4, 3);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(1446, 75);
            MessagePanel.TabIndex = 1;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(57, 3);
            Message.Margin = new Padding(4, 0, 4, 0);
            Message.Name = "Message";
            Message.Size = new Size(59, 25);
            Message.TabIndex = 2;
            Message.Text = "label1";
            // 
            // MessageIcon
            // 
            MessageIcon.Image = GroupProject.Properties.Resources.InfoIcon;
            MessageIcon.Location = new Point(4, 3);
            MessageIcon.Margin = new Padding(4, 3, 4, 3);
            MessageIcon.Name = "MessageIcon";
            MessageIcon.Size = new Size(46, 47);
            MessageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageIcon.TabIndex = 0;
            MessageIcon.TabStop = false;
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.BackColor = SystemColors.GradientActiveCaption;
            TitleBarPanel.Controls.Add(RightMenuBarPanel);
            TitleBarPanel.Controls.Add(MinButton);
            TitleBarPanel.Controls.Add(MaxButton);
            TitleBarPanel.Controls.Add(CloseButton);
            TitleBarPanel.Dock = DockStyle.Top;
            TitleBarPanel.Location = new Point(287, 0);
            TitleBarPanel.Margin = new Padding(4, 5, 4, 5);
            TitleBarPanel.Name = "TitleBarPanel";
            TitleBarPanel.Padding = new Padding(6, 7, 6, 7);
            TitleBarPanel.Size = new Size(1159, 82);
            TitleBarPanel.TabIndex = 1;
            TitleBarPanel.Paint += TitleBarPanel_Paint;
            TitleBarPanel.MouseDown += TitleBarPanel_MouseDown;
            TitleBarPanel.Resize += TitleBarPanel_Resize;
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Dock = DockStyle.Right;
            RightMenuBarPanel.Location = new Point(587, 7);
            RightMenuBarPanel.Margin = new Padding(4, 5, 4, 5);
            RightMenuBarPanel.Name = "RightMenuBarPanel";
            RightMenuBarPanel.Size = new Size(356, 68);
            RightMenuBarPanel.TabIndex = 6;
            // 
            // MinButton
            // 
            MinButton.BackColor = SystemColors.GradientActiveCaption;
            MinButton.Dock = DockStyle.Right;
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.FlatStyle = FlatStyle.Flat;
            MinButton.Location = new Point(943, 7);
            MinButton.Margin = new Padding(0);
            MinButton.Name = "MinButton";
            MinButton.Size = new Size(70, 68);
            MinButton.TabIndex = 2;
            MinButton.UseVisualStyleBackColor = false;
            MinButton.Click += MinButton_Click;
            // 
            // MaxButton
            // 
            MaxButton.BackColor = Color.Transparent;
            MaxButton.Dock = DockStyle.Right;
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.FlatStyle = FlatStyle.Flat;
            MaxButton.Location = new Point(1013, 7);
            MaxButton.Margin = new Padding(4, 5, 4, 5);
            MaxButton.Name = "MaxButton";
            MaxButton.Size = new Size(70, 68);
            MaxButton.TabIndex = 1;
            MaxButton.UseVisualStyleBackColor = false;
            MaxButton.Click += MaxButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Transparent;
            CloseButton.Dock = DockStyle.Right;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Location = new Point(1083, 7);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(70, 68);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = SystemColors.MenuHighlight;
            MenuPanel.Controls.Add(ExpensesMenuButton);
            MenuPanel.Controls.Add(CardMenuButton);
            MenuPanel.Controls.Add(IncomeMenuButton);
            MenuPanel.Controls.Add(GoalsMenuButton);
            MenuPanel.Controls.Add(SubscriptionMenuButton);
            MenuPanel.Controls.Add(CalendarMenuButton);
            MenuPanel.Controls.Add(HomeMenuButton);
            MenuPanel.Controls.Add(LogoLable);
            MenuPanel.Controls.Add(MenuButton);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Margin = new Padding(4, 5, 4, 5);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(287, 865);
            MenuPanel.TabIndex = 12;
            // 
            // ExpensesMenuButton
            // 
            ExpensesMenuButton.Dock = DockStyle.Top;
            ExpensesMenuButton.FlatAppearance.BorderSize = 0;
            ExpensesMenuButton.FlatStyle = FlatStyle.Flat;
            ExpensesMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpensesMenuButton.ForeColor = Color.White;
            ExpensesMenuButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            ExpensesMenuButton.IconColor = Color.White;
            ExpensesMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ExpensesMenuButton.IconSize = 30;
            ExpensesMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            ExpensesMenuButton.Location = new Point(0, 407);
            ExpensesMenuButton.Margin = new Padding(4, 5, 4, 5);
            ExpensesMenuButton.Name = "ExpensesMenuButton";
            ExpensesMenuButton.Size = new Size(287, 57);
            ExpensesMenuButton.TabIndex = 8;
            ExpensesMenuButton.Tag = "Expenses";
            ExpensesMenuButton.Text = "Expenses";
            ExpensesMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            ExpensesMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            ExpensesMenuButton.UseVisualStyleBackColor = true;
            // 
            // CardMenuButton
            // 
            CardMenuButton.Dock = DockStyle.Top;
            CardMenuButton.FlatAppearance.BorderSize = 0;
            CardMenuButton.FlatStyle = FlatStyle.Flat;
            CardMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CardMenuButton.ForeColor = Color.White;
            CardMenuButton.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            CardMenuButton.IconColor = Color.White;
            CardMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CardMenuButton.IconSize = 30;
            CardMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            CardMenuButton.Location = new Point(0, 350);
            CardMenuButton.Margin = new Padding(4, 5, 4, 5);
            CardMenuButton.Name = "CardMenuButton";
            CardMenuButton.Size = new Size(287, 57);
            CardMenuButton.TabIndex = 7;
            CardMenuButton.Tag = "Cards";
            CardMenuButton.Text = "Cards";
            CardMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            CardMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CardMenuButton.UseVisualStyleBackColor = true;
            CardMenuButton.Click += CardMenuButton_Click;
            // 
            // IncomeMenuButton
            // 
            IncomeMenuButton.Dock = DockStyle.Top;
            IncomeMenuButton.FlatAppearance.BorderSize = 0;
            IncomeMenuButton.FlatStyle = FlatStyle.Flat;
            IncomeMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncomeMenuButton.ForeColor = Color.White;
            IncomeMenuButton.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            IncomeMenuButton.IconColor = Color.White;
            IncomeMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IncomeMenuButton.IconSize = 30;
            IncomeMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            IncomeMenuButton.Location = new Point(0, 293);
            IncomeMenuButton.Margin = new Padding(4, 5, 4, 5);
            IncomeMenuButton.Name = "IncomeMenuButton";
            IncomeMenuButton.Size = new Size(287, 57);
            IncomeMenuButton.TabIndex = 6;
            IncomeMenuButton.Tag = "Income";
            IncomeMenuButton.Text = "Income";
            IncomeMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            IncomeMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            IncomeMenuButton.UseVisualStyleBackColor = true;
            IncomeMenuButton.Click += IncomeMenuButton_Click;
            // 
            // GoalsMenuButton
            // 
            GoalsMenuButton.Dock = DockStyle.Top;
            GoalsMenuButton.FlatAppearance.BorderSize = 0;
            GoalsMenuButton.FlatStyle = FlatStyle.Flat;
            GoalsMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoalsMenuButton.ForeColor = Color.White;
            GoalsMenuButton.IconChar = FontAwesome.Sharp.IconChar.Bullseye;
            GoalsMenuButton.IconColor = Color.White;
            GoalsMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            GoalsMenuButton.IconSize = 30;
            GoalsMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            GoalsMenuButton.Location = new Point(0, 236);
            GoalsMenuButton.Margin = new Padding(4, 5, 4, 5);
            GoalsMenuButton.Name = "GoalsMenuButton";
            GoalsMenuButton.Size = new Size(287, 57);
            GoalsMenuButton.TabIndex = 5;
            GoalsMenuButton.Tag = "Goals";
            GoalsMenuButton.Text = "Goals";
            GoalsMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            GoalsMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GoalsMenuButton.UseVisualStyleBackColor = true;
            GoalsMenuButton.Click += GoalsMenuButton_Click;
            // 
            // SubscriptionMenuButton
            // 
            SubscriptionMenuButton.Dock = DockStyle.Top;
            SubscriptionMenuButton.FlatAppearance.BorderSize = 0;
            SubscriptionMenuButton.FlatStyle = FlatStyle.Flat;
            SubscriptionMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubscriptionMenuButton.ForeColor = Color.White;
            SubscriptionMenuButton.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            SubscriptionMenuButton.IconColor = Color.White;
            SubscriptionMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubscriptionMenuButton.IconSize = 30;
            SubscriptionMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            SubscriptionMenuButton.Location = new Point(0, 179);
            SubscriptionMenuButton.Margin = new Padding(4, 5, 4, 5);
            SubscriptionMenuButton.Name = "SubscriptionMenuButton";
            SubscriptionMenuButton.Size = new Size(287, 57);
            SubscriptionMenuButton.TabIndex = 4;
            SubscriptionMenuButton.Tag = "Subscriptions";
            SubscriptionMenuButton.Text = "Subscriptions";
            SubscriptionMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            SubscriptionMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SubscriptionMenuButton.UseVisualStyleBackColor = true;
            SubscriptionMenuButton.Click += SubscriptionMenuButton_Click;
            // 
            // CalendarMenuButton
            // 
            CalendarMenuButton.Dock = DockStyle.Top;
            CalendarMenuButton.FlatAppearance.BorderSize = 0;
            CalendarMenuButton.FlatStyle = FlatStyle.Flat;
            CalendarMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalendarMenuButton.ForeColor = Color.White;
            CalendarMenuButton.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            CalendarMenuButton.IconColor = Color.White;
            CalendarMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            CalendarMenuButton.IconSize = 30;
            CalendarMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            CalendarMenuButton.Location = new Point(0, 122);
            CalendarMenuButton.Margin = new Padding(4, 5, 4, 5);
            CalendarMenuButton.Name = "CalendarMenuButton";
            CalendarMenuButton.Size = new Size(287, 57);
            CalendarMenuButton.TabIndex = 3;
            CalendarMenuButton.Tag = "Calendar";
            CalendarMenuButton.Text = "Calendar";
            CalendarMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            CalendarMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CalendarMenuButton.UseVisualStyleBackColor = true;
            // 
            // HomeMenuButton
            // 
            HomeMenuButton.Dock = DockStyle.Top;
            HomeMenuButton.FlatAppearance.BorderSize = 0;
            HomeMenuButton.FlatStyle = FlatStyle.Flat;
            HomeMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeMenuButton.ForeColor = Color.White;
            HomeMenuButton.IconChar = FontAwesome.Sharp.IconChar.House;
            HomeMenuButton.IconColor = Color.White;
            HomeMenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            HomeMenuButton.IconSize = 30;
            HomeMenuButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeMenuButton.Location = new Point(0, 65);
            HomeMenuButton.Margin = new Padding(4, 5, 4, 5);
            HomeMenuButton.Name = "HomeMenuButton";
            HomeMenuButton.Size = new Size(287, 57);
            HomeMenuButton.TabIndex = 2;
            HomeMenuButton.Tag = "Home";
            HomeMenuButton.Text = "Home";
            HomeMenuButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeMenuButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            HomeMenuButton.UseVisualStyleBackColor = true;
            HomeMenuButton.Click += HomeMenuButton_Click;
            // 
            // LogoLable
            // 
            LogoLable.AutoSize = true;
            LogoLable.Dock = DockStyle.Top;
            LogoLable.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoLable.ForeColor = Color.White;
            LogoLable.Location = new Point(0, 0);
            LogoLable.Margin = new Padding(4, 0, 4, 0);
            LogoLable.Name = "LogoLable";
            LogoLable.Size = new Size(205, 65);
            LogoLable.TabIndex = 1;
            LogoLable.Text = "BUDGET";
            // 
            // MenuButton
            // 
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            MenuButton.IconColor = Color.White;
            MenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuButton.IconSize = 30;
            MenuButton.Location = new Point(197, 0);
            MenuButton.Margin = new Padding(4, 5, 4, 5);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(86, 100);
            MenuButton.TabIndex = 0;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // BudgetPlannerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(1446, 940);
            Controls.Add(MainPanel);
            Controls.Add(TitleBarPanel);
            Controls.Add(MenuPanel);
            Controls.Add(MessagePanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "BudgetPlannerForm";
            Text = "Budget Planner";
            Load += BudgetPlannerForm_Load;
            Resize += BudgetPlannerForm_Resize;
            MessagePanel.ResumeLayout(false);
            MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).EndInit();
            TitleBarPanel.ResumeLayout(false);
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel MessagePanel;
        private PictureBox MessageIcon;
        private Label Message;
        private Panel TitleBarPanel;
        private Button MaxButton;
        private Button CloseButton;
        private Button MinButton;
        private Panel RightMenuBarPanel;
        private Panel MenuPanel;
        private FontAwesome.Sharp.IconButton HomeMenuButton;
        private Label LogoLable;
        private FontAwesome.Sharp.IconButton MenuButton;
        private FontAwesome.Sharp.IconButton IncomeMenuButton;
        private FontAwesome.Sharp.IconButton GoalsMenuButton;
        private FontAwesome.Sharp.IconButton SubscriptionMenuButton;
        private FontAwesome.Sharp.IconButton CalendarMenuButton;
        private FontAwesome.Sharp.IconButton CardMenuButton;
        private FontAwesome.Sharp.IconButton ExpensesMenuButton;
    }
}
