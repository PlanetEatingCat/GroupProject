

namespace BudgetPlanner
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MessagePanel = new Panel();
            Message = new Label();
            MessageIcon = new PictureBox();
            MenuButton = new FontAwesome.Sharp.IconButton();
            LogoLable = new Label();
            HomeMenuButton = new MenuButton();
            SubscriptionMenuButton = new MenuButton();
            GoalsMenuButton = new MenuButton();
            IncomeMenuButton = new MenuButton();
            ExpensesMenuButton = new MenuButton();
            MenuPanel = new Panel();
            ThemeMenuButton = new MenuButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            TitleBarPanel.SuspendLayout();
            MessagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).BeginInit();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RightMenuBarPanel
            // 
            RightMenuBarPanel.Location = new Point(631, 0);
            RightMenuBarPanel.Margin = new Padding(4, 5, 4, 5);
            RightMenuBarPanel.Size = new Size(94, 66);
            // 
            // MinButton
            // 
            MinButton.FlatAppearance.BorderSize = 0;
            MinButton.Image = (Image)resources.GetObject("MinButton.Image");
            MinButton.Location = new Point(725, 0);
            MinButton.Size = new Size(66, 66);
            // 
            // MaxButton
            // 
            MaxButton.FlatAppearance.BorderSize = 0;
            MaxButton.Image = (Image)resources.GetObject("MaxButton.Image");
            MaxButton.Location = new Point(791, 0);
            MaxButton.Margin = new Padding(4, 5, 4, 5);
            MaxButton.Size = new Size(66, 66);
            // 
            // CloseButton
            // 
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(857, 0);
            CloseButton.Margin = new Padding(4, 5, 4, 5);
            CloseButton.Size = new Size(66, 66);
            // 
            // LeftMenuBarPanel
            // 
            LeftMenuBarPanel.Margin = new Padding(4, 5, 4, 5);
            LeftMenuBarPanel.Size = new Size(250, 66);
            // 
            // BaseMainPanel
            // 
            BaseMainPanel.Location = new Point(232, 68);
            BaseMainPanel.Margin = new Padding(4);
            BaseMainPanel.Padding = new Padding(4);
            BaseMainPanel.Size = new Size(923, 622);
            // 
            // TitleBarPanel
            // 
            TitleBarPanel.Location = new Point(232, 2);
            TitleBarPanel.Margin = new Padding(4);
            TitleBarPanel.Size = new Size(923, 66);
            // 
            // MessagePanel
            // 
            MessagePanel.BackColor = Color.LightSkyBlue;
            MessagePanel.Controls.Add(Message);
            MessagePanel.Controls.Add(MessageIcon);
            MessagePanel.Dock = DockStyle.Bottom;
            MessagePanel.Location = new Point(2, 690);
            MessagePanel.Margin = new Padding(3, 2, 3, 2);
            MessagePanel.Name = "MessagePanel";
            MessagePanel.Size = new Size(1153, 60);
            MessagePanel.TabIndex = 1;
            // 
            // Message
            // 
            Message.AutoSize = true;
            Message.Location = new Point(46, 2);
            Message.Name = "Message";
            Message.Size = new Size(50, 20);
            Message.TabIndex = 2;
            Message.Text = "label1";
            // 
            // MessageIcon
            // 
            MessageIcon.Image = GroupProject.Properties.Resources.InfoIcon;
            MessageIcon.Location = new Point(3, 2);
            MessageIcon.Margin = new Padding(3, 2, 3, 2);
            MessageIcon.Name = "MessageIcon";
            MessageIcon.Size = new Size(37, 38);
            MessageIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            MessageIcon.TabIndex = 0;
            MessageIcon.TabStop = false;
            // 
            // MenuButton
            // 
            MenuButton.FlatAppearance.BorderSize = 0;
            MenuButton.FlatStyle = FlatStyle.Flat;
            MenuButton.IconChar = FontAwesome.Sharp.IconChar.Bars;
            MenuButton.IconColor = Color.White;
            MenuButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuButton.IconSize = 30;
            MenuButton.Location = new Point(161, 0);
            MenuButton.Margin = new Padding(3, 4, 3, 4);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(69, 80);
            MenuButton.TabIndex = 0;
            MenuButton.UseVisualStyleBackColor = true;
            MenuButton.Click += MenuButton_Click;
            // 
            // LogoLable
            // 
            LogoLable.AutoSize = true;
            LogoLable.Dock = DockStyle.Top;
            LogoLable.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoLable.ForeColor = Color.White;
            LogoLable.Location = new Point(0, 0);
            LogoLable.Name = "LogoLable";
            LogoLable.Size = new Size(169, 54);
            LogoLable.TabIndex = 1;
            LogoLable.Text = "BUDGET";
            // 
            // HomeMenuButton
            // 
            HomeMenuButton.Active = true;
            HomeMenuButton.ActiveColor = Color.White;
            HomeMenuButton.ActiveIndicatorColor = SystemColors.MenuHighlight;
            HomeMenuButton.AutoValidate = AutoValidate.Disable;
            HomeMenuButton.BackColor = SystemColors.MenuHighlight;
            HomeMenuButton.Dock = DockStyle.Top;
            HomeMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeMenuButton.ForeColor = Color.White;
            HomeMenuButton.IconChar = FontAwesome.Sharp.IconChar.House;
            HomeMenuButton.IconColor = Color.White;
            HomeMenuButton.Label = "Home";
            HomeMenuButton.Location = new Point(0, 54);
            HomeMenuButton.Margin = new Padding(3, 4, 3, 4);
            HomeMenuButton.Name = "HomeMenuButton";
            HomeMenuButton.NormalColor = SystemColors.MenuHighlight;
            HomeMenuButton.Size = new Size(230, 46);
            HomeMenuButton.TabIndex = 2;
            HomeMenuButton.Tag = "Home";
            HomeMenuButton.Click += HomeMenuButton_Click;
            // 
            // SubscriptionMenuButton
            // 
            SubscriptionMenuButton.Active = false;
            SubscriptionMenuButton.ActiveColor = Color.White;
            SubscriptionMenuButton.ActiveIndicatorColor = SystemColors.MenuHighlight;
            SubscriptionMenuButton.BackColor = SystemColors.MenuHighlight;
            SubscriptionMenuButton.Dock = DockStyle.Top;
            SubscriptionMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubscriptionMenuButton.ForeColor = Color.White;
            SubscriptionMenuButton.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            SubscriptionMenuButton.IconColor = Color.White;
            SubscriptionMenuButton.Label = "Subscriptions";
            SubscriptionMenuButton.Location = new Point(0, 100);
            SubscriptionMenuButton.Margin = new Padding(3, 4, 3, 4);
            SubscriptionMenuButton.Name = "SubscriptionMenuButton";
            SubscriptionMenuButton.NormalColor = SystemColors.MenuHighlight;
            SubscriptionMenuButton.Size = new Size(230, 46);
            SubscriptionMenuButton.TabIndex = 4;
            SubscriptionMenuButton.Tag = "Subscriptions";
            SubscriptionMenuButton.Click += SubscriptionMenuButton_Click;
            // 
            // GoalsMenuButton
            // 
            GoalsMenuButton.Active = false;
            GoalsMenuButton.ActiveColor = Color.White;
            GoalsMenuButton.ActiveIndicatorColor = SystemColors.MenuHighlight;
            GoalsMenuButton.BackColor = SystemColors.MenuHighlight;
            GoalsMenuButton.Dock = DockStyle.Top;
            GoalsMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GoalsMenuButton.ForeColor = Color.White;
            GoalsMenuButton.IconChar = FontAwesome.Sharp.IconChar.Bullseye;
            GoalsMenuButton.IconColor = Color.White;
            GoalsMenuButton.Label = "Goals";
            GoalsMenuButton.Location = new Point(0, 146);
            GoalsMenuButton.Margin = new Padding(3, 4, 3, 4);
            GoalsMenuButton.Name = "GoalsMenuButton";
            GoalsMenuButton.NormalColor = SystemColors.MenuHighlight;
            GoalsMenuButton.Size = new Size(230, 46);
            GoalsMenuButton.TabIndex = 5;
            GoalsMenuButton.Tag = "Goals";
            GoalsMenuButton.Click += GoalsMenuButton_Click;
            // 
            // IncomeMenuButton
            // 
            IncomeMenuButton.Active = false;
            IncomeMenuButton.ActiveColor = Color.White;
            IncomeMenuButton.ActiveIndicatorColor = SystemColors.MenuHighlight;
            IncomeMenuButton.BackColor = SystemColors.MenuHighlight;
            IncomeMenuButton.Dock = DockStyle.Top;
            IncomeMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IncomeMenuButton.ForeColor = Color.White;
            IncomeMenuButton.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            IncomeMenuButton.IconColor = Color.White;
            IncomeMenuButton.Label = "Icome";
            IncomeMenuButton.Location = new Point(0, 192);
            IncomeMenuButton.Margin = new Padding(3, 4, 3, 4);
            IncomeMenuButton.Name = "IncomeMenuButton";
            IncomeMenuButton.NormalColor = SystemColors.MenuHighlight;
            IncomeMenuButton.Size = new Size(230, 46);
            IncomeMenuButton.TabIndex = 6;
            IncomeMenuButton.Tag = "Income";
            IncomeMenuButton.Click += IncomeMenuButton_Click;
            // 
            // ExpensesMenuButton
            // 
            ExpensesMenuButton.Active = false;
            ExpensesMenuButton.ActiveColor = Color.White;
            ExpensesMenuButton.ActiveIndicatorColor = SystemColors.MenuHighlight;
            ExpensesMenuButton.BackColor = SystemColors.MenuHighlight;
            ExpensesMenuButton.Dock = DockStyle.Top;
            ExpensesMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExpensesMenuButton.ForeColor = Color.White;
            ExpensesMenuButton.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1;
            ExpensesMenuButton.IconColor = Color.White;
            ExpensesMenuButton.Label = "Expenses";
            ExpensesMenuButton.Location = new Point(0, 238);
            ExpensesMenuButton.Margin = new Padding(3, 4, 3, 4);
            ExpensesMenuButton.Name = "ExpensesMenuButton";
            ExpensesMenuButton.NormalColor = SystemColors.MenuHighlight;
            ExpensesMenuButton.Size = new Size(230, 46);
            ExpensesMenuButton.TabIndex = 8;
            ExpensesMenuButton.Tag = "Expenses";
            ExpensesMenuButton.Click += ExpensesMenuButton_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = SystemColors.MenuHighlight;
            MenuPanel.Controls.Add(ThemeMenuButton);
            MenuPanel.Controls.Add(ExpensesMenuButton);
            MenuPanel.Controls.Add(IncomeMenuButton);
            MenuPanel.Controls.Add(GoalsMenuButton);
            MenuPanel.Controls.Add(SubscriptionMenuButton);
            MenuPanel.Controls.Add(HomeMenuButton);
            MenuPanel.Controls.Add(LogoLable);
            MenuPanel.Controls.Add(MenuButton);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Location = new Point(2, 2);
            MenuPanel.Margin = new Padding(3, 4, 3, 4);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(230, 688);
            MenuPanel.TabIndex = 12;
            // 
            // ThemeMenuButton
            // 
            ThemeMenuButton.Active = false;
            ThemeMenuButton.ActiveColor = Color.White;
            ThemeMenuButton.ActiveIndicatorColor = SystemColors.MenuHighlight;
            ThemeMenuButton.BackColor = SystemColors.MenuHighlight;
            ThemeMenuButton.Dock = DockStyle.Top;
            ThemeMenuButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ThemeMenuButton.ForeColor = Color.White;
            ThemeMenuButton.IconChar = FontAwesome.Sharp.IconChar.Panorama;
            ThemeMenuButton.IconColor = Color.White;
            ThemeMenuButton.Label = "Themes";
            ThemeMenuButton.Location = new Point(0, 284);
            ThemeMenuButton.Margin = new Padding(3, 4, 3, 4);
            ThemeMenuButton.Name = "ThemeMenuButton";
            ThemeMenuButton.NormalColor = SystemColors.MenuHighlight;
            ThemeMenuButton.Size = new Size(230, 46);
            ThemeMenuButton.TabIndex = 9;
            ThemeMenuButton.Tag = "Expenses";
            ThemeMenuButton.Click += ThemeMenuButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1157, 752);
            Controls.Add(MenuPanel);
            Controls.Add(MessagePanel);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(0, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Padding = new Padding(2);
            Text = "Budget Planner";
            Load += BudgetPlannerForm_Load;
            Controls.SetChildIndex(MessagePanel, 0);
            Controls.SetChildIndex(MenuPanel, 0);
            Controls.SetChildIndex(TitleBarPanel, 0);
            Controls.SetChildIndex(BaseMainPanel, 0);
            TitleBarPanel.ResumeLayout(false);
            MessagePanel.ResumeLayout(false);
            MessagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MessageIcon).EndInit();
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel MessagePanel;
        private PictureBox MessageIcon;
        private Label Message;
        private FontAwesome.Sharp.IconButton MenuButton;
        private Label LogoLable;
        private MenuButton HomeMenuButton;
        private MenuButton SubscriptionMenuButton;
        private MenuButton GoalsMenuButton;
        private MenuButton IncomeMenuButton;
        private MenuButton ExpensesMenuButton;
        private Panel MenuPanel;
        private ContextMenuStrip contextMenuStrip1;
        private MenuButton ThemeMenuButton;
    }
}
