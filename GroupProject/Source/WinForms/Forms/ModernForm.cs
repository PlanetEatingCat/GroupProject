/********************************************
Name: BaseForm.cs
Purpose: Provide a base class to create a form with a modern title bar and border
Notes: Authored by Daniel.
********************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class ModernForm : Form
    {
        

        //-----------------------------------------------------------------------------------------------
        // Variables
        //-----------------------------------------------------------------------------------------------

        protected const int WM_NCLBUTTONDOWN = 0xA1; // For custom title bar dragging
        protected const int HT_CAPTION = 0x2;
        protected const int RESIZE_HANDLE_SIZE = 8; // For resizing with custom window border

        Color m_TitleButtonTint = Color.White;

        //-----------------------------------------------------------------------------------------------
        // Ecapsulated windows functionality
        //-----------------------------------------------------------------------------------------------

        protected static class WindowsInterface
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



        //-----------------------------------------------------------------------------------------------
        // Form
        //-----------------------------------------------------------------------------------------------
        public ModernForm()
        {
            SetFormRoundedCorners(true);
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            // Load emmeded icons
            var closeIcon = ImageUtils.LoadPng(Icons.WindowCloseIcon);
            var minIcon = ImageUtils.LoadPng(Icons.WindowMinimizeIcon);
            var maxIcon = ImageUtils.LoadPng(Icons.WindowMaximizeIcon);

            CloseButton.Image = ImageUtils.TintImage(closeIcon, m_TitleButtonTint);
            MinButton.Image = ImageUtils.TintImage(minIcon, m_TitleButtonTint);
            MaxButton.Image = ImageUtils.TintImage(maxIcon, m_TitleButtonTint);
        }

        public void SetTitleButtonTint(Color InTint)
        {
            m_TitleButtonTint = InTint;

            CloseButton.Image = ImageUtils.TintImage(CloseButton.Image, m_TitleButtonTint);
            MinButton.Image = ImageUtils.TintImage(MinButton.Image, m_TitleButtonTint);
            MaxButton.Image = ImageUtils.TintImage(MaxButton.Image, m_TitleButtonTint);
        }


        //-----------------------------------------------------------------------------------------------
        // Title Buttons
        //-----------------------------------------------------------------------------------------------

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.Padding = new Padding(2);
                WindowState = FormWindowState.Normal;
                var maxIcon = ImageUtils.LoadPng(Icons.WindowMaximizeIcon);
                MaxButton.Image = ImageUtils.TintImage(maxIcon, m_TitleButtonTint);
                SetFormRoundedCorners(true);
            }

            else
            {
                this.Padding = new Padding(0);
                WindowState = FormWindowState.Maximized;
                var maxIcon = ImageUtils.LoadPng(Icons.WindowRestoreIcon);
                MaxButton.Image = ImageUtils.TintImage(maxIcon, m_TitleButtonTint);
                SetFormRoundedCorners(false);
            }
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //-----------------------------------------------------------------------------------------------
        // TitleBarPanel
        //-----------------------------------------------------------------------------------------------

        private void TitleBarPanel_Resize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                this.Padding = new Padding(2);
                var maxIcon = ImageUtils.LoadPng(Icons.WindowMaximizeIcon);
                MaxButton.Image = ImageUtils.TintImage(maxIcon, m_TitleButtonTint);
                SetFormRoundedCorners(true);
            }
        }

        private void TitleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowsInterface.ReleaseCapture();
                WindowsInterface.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //-----------------------------------------------------------------------------------------------
        // Utilities
        //-----------------------------------------------------------------------------------------------

        public virtual void ApplyTheme(Theme InTheme)
        {
            this.BackColor = InTheme.Border;
            RightMenuBarPanel.BackColor = InTheme.Background;
            MinButton.BackColor = InTheme.Background;
            MaxButton.BackColor = InTheme.Background;
            CloseButton.BackColor = InTheme.Background;
            BaseMainPanel.BackColor = InTheme.Background;
            TitleBarPanel.BackColor = InTheme.Background;

         /*   foreach (Control c in this.Controls)
            {
                if (c is Button btn)
                {
                    btn.BackColor = config.AccentColor;
                    btn.FlatStyle = config.ButtonStyle;
                }
            }*/
        }

        protected void SetFormRoundedCorners(bool InCornerRounding)
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

        //-----------------------------------------------------------------------------------------------
        // Move and Resize 
        //-----------------------------------------------------------------------------------------------

        protected override void WndProc(ref Message InMessage)
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

            if (InMessage.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref InMessage);

                var cursor = PointToClient(Cursor.Position);

                if (WindowState == FormWindowState.Maximized)
                    return;

                bool left = cursor.X <= RESIZE_HANDLE_SIZE;
                bool right = cursor.X >= Width - RESIZE_HANDLE_SIZE;
                bool top = cursor.Y <= RESIZE_HANDLE_SIZE;
                bool bottom = cursor.Y >= Height - RESIZE_HANDLE_SIZE;

                if (left && top) { InMessage.Result = (IntPtr)HTTOPLEFT; return; }
                if (right && top) { InMessage.Result = (IntPtr)HTTOPRIGHT; return; }
                if (left && bottom) { InMessage.Result = (IntPtr)HTBOTTOMLEFT; return; }
                if (right && bottom) { InMessage.Result = (IntPtr)HTBOTTOMRIGHT; return; }
                if (left) { InMessage.Result = (IntPtr)HTLEFT; return; }
                if (right) { InMessage.Result = (IntPtr)HTRIGHT; return; }
                if (top) { InMessage.Result = (IntPtr)HTTOP; return; }
                if (bottom) { InMessage.Result = (IntPtr)HTBOTTOM; return; }

                if (TitleBarPanel.ClientRectangle.Contains(TitleBarPanel.PointToClient(Cursor.Position)))
                {
                    InMessage.Result = (IntPtr)HTCAPTION;
                    return;
                }

                return;
            }

            base.WndProc(ref InMessage);
        }
    }
}
