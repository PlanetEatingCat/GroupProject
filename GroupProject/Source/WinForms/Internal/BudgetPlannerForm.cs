
using GroupProject.Properties;
using System;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Windows.Devices.Radios;

namespace BudgetPlanner
{
    public partial class BudgetPlannerForm : Form
    {
        private const int MESSAGE_VANISH_TIME = 5000; // 5 seconds

        public const int WM_NCLBUTTONDOWN = 0xA1; // For custom title bar dragging
        public const int HT_CAPTION = 0x2;
        private const int RESIZE_HANDLE_SIZE = 8; // For resizing with custom window border

        // For error and success message system
        private System.Windows.Forms.Timer m_MessageTimer = new System.Windows.Forms.Timer();

        DebugConsoleForm m_DebugConsoleForm;
        SignInScreen m_SignInScreen;

        private int m_PreviousWidth = 0;

        private static class WindowsInterface
        {
            public enum DwmWindowCornerPreference
            {
                Default = 0,
                DoNotRound = 1,
                Round = 2,
                RoundSmall = 3
            }

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool ReleaseCapture();

            [System.Runtime.InteropServices.DllImport("dwmapi.dll")]
            public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref DwmWindowCornerPreference pref, int size);
        }

        public BudgetPlannerForm()
        {
            InitializeComponent();
            m_PreviousWidth = MenuPanel.Width;

            Logger.OnLogToGUI += Logger_OnLog;
            ScreenManager.Initialize(this, MainPanel, RightMenuBarPanel);
        }

        private void BudgetPlannerForm_Load(object InSender, EventArgs InEvent)
        {
            // This creates the border around the window for resizing
            this.Padding = new Padding(2);
            SetFormRoundedCorners(true);

            // Load title bar icons
            CloseButton.Image = Utils.LoadPng(Icons.g_WindowCloseIcon);
            MinButton.Image = Utils.LoadPng(Icons.g_WindowMinimizeIcon);
            MaxButton.Image = Utils.LoadPng(Icons.g_WindowMaximizeIcon);

            // Creates error timer. Used to hide error message after five seconds
            m_MessageTimer = new System.Windows.Forms.Timer();
            m_MessageTimer.Interval = MESSAGE_VANISH_TIME; // 5 seconds
            m_MessageTimer.Tick += (s, e) =>
            {
                MessagePanel.Visible = false;
                m_MessageTimer.Stop();
            };


            // Initialize state of panels
            MessagePanel.Visible = false;
            ScreenManager.SwitchScreens(new SignInScreen());



            // Show Console
            m_DebugConsoleForm = new DebugConsoleForm();
            m_DebugConsoleForm.Show();

            // Test messages
            Logger.ConsoleError("This is an error test");
            Logger.ConsoleInfo("This is a Message test");
            Logger.ConsoleWarn("This is a warning test");
        }

        // --------------------------------------------------------------------------------------------------
        // Title Bar buttons
        // --------------------------------------------------------------------------------------------------

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.Padding = new Padding(1);
                WindowState = FormWindowState.Normal;
                MaxButton.Image = Utils.LoadPng(Icons.g_WindowMaximizeIcon);
                SetFormRoundedCorners(true);
            }

            else
            {
                this.Padding = new Padding(0);
                WindowState = FormWindowState.Maximized;
                MaxButton.Image = Utils.LoadPng(Icons.g_WindowRestoreIcon);
                SetFormRoundedCorners(false);
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // --------------------------------------------------------------------------------------------------
        // Title Bar Panel
        // --------------------------------------------------------------------------------------------------

        private void TitleBarPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsInterface.ReleaseCapture();
                WindowsInterface.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void TitleBarPanel_Resize(object sender, EventArgs e)
        {
            /* if (WindowState != FormWindowState.Maximized)
                 ApplyRoundedCorners(TitleBarPanel, 6, 6, 0, 0); // 12px radius looks nice
             else
                 ApplyRoundedCorners(TitleBarPanel, 0, 0, 0, 0); // 12px radius looks nice*/
        }

        // --------------------------------------------------------------------------------------------------
        // Main Panel
        // --------------------------------------------------------------------------------------------------

        private void MainPanel_Resize(object sender, EventArgs e)
        {
            /* if (WindowState != FormWindowState.Maximized)
                 ApplyRoundedCorners(MainPanel, 6, 6, 6, 6);
             else
                 ApplyRoundedCorners(MainPanel, 0, 0, 0, 0); // 12px radius looks nice*/
        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        }

        // --------------------------------------------------------------------------------------------------
        // Custom Title bar 
        // --------------------------------------------------------------------------------------------------

        private void SetFormRoundedCorners(bool InCornerRounding)
        {
            if (!InCornerRounding)
            {
                var pref = WindowsInterface.DwmWindowCornerPreference.Default;
                WindowsInterface.DwmSetWindowAttribute(this.Handle, 33, ref pref, sizeof(int));
            }
            else
            {
                var pref = WindowsInterface.DwmWindowCornerPreference.Round;
                WindowsInterface.DwmSetWindowAttribute(this.Handle, 33, ref pref, sizeof(int));
            }
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            const int HTLEFT = 10;
            const int HTRIGHT = 11;
            const int HTTOP = 12;
            const int HTTOPLEFT = 13;
            const int HTTOPRIGHT = 14;
            const int HTBOTTOM = 15;
            const int HTBOTTOMLEFT = 16;
            const int HTBOTTOMRIGHT = 17;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);

                var cursor = PointToClient(Cursor.Position);

                if (WindowState == FormWindowState.Maximized)
                    return;

                // 1. RESIZE ZONES FIRST
                bool left = cursor.X <= RESIZE_HANDLE_SIZE;
                bool right = cursor.X >= Width - RESIZE_HANDLE_SIZE;
                bool top = cursor.Y <= RESIZE_HANDLE_SIZE;
                bool bottom = cursor.Y >= Height - RESIZE_HANDLE_SIZE;

                if (left && top) { m.Result = (IntPtr)HTTOPLEFT; return; }
                if (right && top) { m.Result = (IntPtr)HTTOPRIGHT; return; }
                if (left && bottom) { m.Result = (IntPtr)HTBOTTOMLEFT; return; }
                if (right && bottom) { m.Result = (IntPtr)HTBOTTOMRIGHT; return; }
                if (left) { m.Result = (IntPtr)HTLEFT; return; }
                if (right) { m.Result = (IntPtr)HTRIGHT; return; }
                if (top) { m.Result = (IntPtr)HTTOP; return; }
                if (bottom) { m.Result = (IntPtr)HTBOTTOM; return; }

                // 2. TITLE BAR PANEL DRAGGING
                if (TitleBarPanel.ClientRectangle.Contains(TitleBarPanel.PointToClient(Cursor.Position)))
                {
                    m.Result = (IntPtr)HTCAPTION;
                    return;
                }

                return;
            }

            base.WndProc(ref m);
        }

        // --------------------------------------------------------------------------------------------------
        // Logging
        // --------------------------------------------------------------------------------------------------
        private void Logger_OnLog(string InMessage, MessageType InType)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Logger_OnLog(InMessage, InType)));
                return;
            }

            switch (InType)
            {
                case MessageType.Error:
                    MessagePanel.BackColor = Color.IndianRed;
                    MessageIcon.Image = Resources.ErrorIcon;
                    break;
                case MessageType.Warn:
                    MessagePanel.BackColor = Color.Moccasin;
                    MessageIcon.Image = Resources.WarnIcon;
                    break;
                case MessageType.Info:
                    MessagePanel.BackColor = Color.LightSkyBlue;
                    MessageIcon.Image = Resources.InfoIcon;
                    break;

            }

            Message.Text = InMessage;
            MessagePanel.Visible = true;

            m_MessageTimer.Stop();
            m_MessageTimer.Start();
        }

        // --------------------------------------------------------------------------------------------------
        // Custom graphics
        // --------------------------------------------------------------------------------------------------
        private GraphicsPath CreateRoundedRect(Rectangle bounds,
            int radiusTopLeft, int radiusTopRight,
            int radiusBottomRight, int radiusBottomLeft)
        {
            GraphicsPath path = new GraphicsPath();

            int tl = radiusTopLeft * 2;
            int tr = radiusTopRight * 2;
            int br = radiusBottomRight * 2;
            int bl = radiusBottomLeft * 2;

            // Top-left corner
            if (radiusTopLeft > 0)
                path.AddArc(bounds.X, bounds.Y, tl, tl, 180, 90);
            else
                path.AddLine(bounds.X, bounds.Y, bounds.X, bounds.Y);

            // Top edge
            path.AddLine(bounds.X + radiusTopLeft, bounds.Y,
                         bounds.Right - radiusTopRight, bounds.Y);

            // Top-right corner
            if (radiusTopRight > 0)
                path.AddArc(bounds.Right - tr, bounds.Y, tr, tr, 270, 90);
            else
                path.AddLine(bounds.Right, bounds.Y, bounds.Right, bounds.Y);

            // Right edge
            path.AddLine(bounds.Right, bounds.Y + radiusTopRight,
                         bounds.Right, bounds.Bottom - radiusBottomRight);

            // Bottom-right corner
            if (radiusBottomRight > 0)
                path.AddArc(bounds.Right - br, bounds.Bottom - br, br, br, 0, 90);
            else
                path.AddLine(bounds.Right, bounds.Bottom, bounds.Right, bounds.Bottom);

            // Bottom edge
            path.AddLine(bounds.Right - radiusBottomRight, bounds.Bottom,
                         bounds.X + radiusBottomLeft, bounds.Bottom);

            // Bottom-left corner
            if (radiusBottomLeft > 0)
                path.AddArc(bounds.X, bounds.Bottom - bl, bl, bl, 90, 90);
            else
                path.AddLine(bounds.X, bounds.Bottom, bounds.X, bounds.Bottom);

            // Left edge
            path.AddLine(bounds.X, bounds.Bottom - radiusBottomLeft,
                         bounds.X, bounds.Y + radiusTopLeft);

            path.CloseFigure();
            return path;
        }

        private void ApplyRoundedCorners(Panel panel,
            int InTopLeft, int InTopRight,
            int InBottemRight, int InBottemLeft)
        {
            panel.Region = new Region(CreateRoundedRect(panel.ClientRectangle,
                InTopLeft, InTopRight,
                InBottemRight, InBottemLeft));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BudgetPlannerForm_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                SetFormRoundedCorners(true);
            }
        }

        public void SetMenuBarActive(bool InActive)
        {
            if (!InActive)
            {
                if (!(MenuPanel.Width >= m_PreviousWidth)) 
                    CollapseMenu();

                foreach (Control control in MenuPanel.Controls)
                {
                    control.Visible = false;
                }
            }
            else
            {
                CollapseMenu();
                foreach (Control control in MenuPanel.Controls)
                {
                    control.Visible = true;
                }
                CollapseMenu();
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            CollapseMenu();

        }


        private void CollapseMenu()
        {
            if (MenuPanel.Width >= m_PreviousWidth) //Collapse menu
            {
                MenuPanel.Width = 100;
                LogoLable.Visible = false;
                MenuButton.Dock = DockStyle.Top;
                foreach (Button menuButton in MenuPanel.Controls.OfType<Button>())
                {
                    if (menuButton.Equals(MenuButton)) continue;

                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                MenuPanel.Width = m_PreviousWidth;
                LogoLable.Visible = true;
                MenuButton.Dock = DockStyle.None;
                foreach (Button menuButton in MenuPanel.Controls.OfType<Button>())
                {
                    if (menuButton.Equals(MenuButton)) continue;

                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

            }
        }

        private void IncomeMenuButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new IncomeScreen());
        }

        private void SubscriptionMenuButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new SubscriptionManagerForm());
        }

        private void HomeMenuButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new DashboardScreen());
        }

        private void GoalsMenuButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new GoalsScreen());
        }

        private void CardMenuButton_Click(object sender, EventArgs e)
        {
            ScreenManager.SwitchScreens(new PaymentScreen());
        }
    }

    internal static class Utils
    {
        public static Image LoadPng(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
