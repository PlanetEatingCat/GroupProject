/********************************************
Name: DebugConsoleForm.cs
Purpose: Debugging
Notes: Authored by Daniel.
********************************************/

using BudgetPlanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class DebugConsoleForm : ModernForm
    {
      //  System.Drawing.Font m_ShareTechFont;

        public DebugConsoleForm()
        {
            InitializeComponent();

          //  PrivateFontCollection pfc = new PrivateFontCollection();
          // pfc.AddFontFile("../../../Resources/Fonts/ShareTech/ShareTech-Regular.ttf"); // path to your font file

            //m_ShareTechFont = new  System.Drawing.Font(pfc.Families[0], 12f, FontStyle.Regular);

            //DebugConsoleBox.Font = m_ShareTechFont;

        }

        private void DebugConsole_Load(object sender, EventArgs e)
        {
            DebugConsoleBox.ItemHeight = TextRenderer.MeasureText("Sample", DebugConsoleBox.Font).Height;
            Logger.OnLogToConsole += Logger_OnLog;
        }
        private List<string> SplitByPixelWidth(string text, Font font, int maxWidth)
        {
            List<string> result = new List<string>();

            string current = text;

            while (TextRenderer.MeasureText(current, font).Width > maxWidth)
            {
                int breakIndex = current.Length - 1;

                // Walk backwards until the substring fits
                while (breakIndex > 0 &&
                       TextRenderer.MeasureText(current.Substring(0, breakIndex), font).Width > maxWidth)
                {
                    breakIndex--;
                }

                // Find last space so we don't cut words in half
                int spaceIndex = current.LastIndexOf(' ', breakIndex);

                if (spaceIndex <= 0)
                    spaceIndex = breakIndex; // no space found, hard cut

                string line = current.Substring(0, spaceIndex).Trim();
                result.Add(line);

                current = current.Substring(spaceIndex).Trim();
            }

            result.Add(current);
            return result;
        }


        private void Logger_OnLog(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Logger_OnLog(msg)));
                return;
            }

            int width = TextRenderer.MeasureText(msg, DebugConsoleBox.Font).Width;

            var lines = SplitByPixelWidth(msg, DebugConsoleBox.Font, DebugConsoleBox.Width);

            foreach (var line in lines)
                DebugConsoleBox.Items.Add(line);
        }

        private void DebugConsoleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DebugConsoleBox_DrawItem(object InSender, DrawItemEventArgs InEvent)
        {
            if (InEvent.Index < 0) return;

            // Draw background (handles selection highlight)
            InEvent.DrawBackground();

            // Pick your color per item
            Color textColor = Color.White;

            // Example: color based on item content
            string text = DebugConsoleBox.Items[InEvent.Index].ToString();
            if (text.Contains("Error"))
                textColor = Color.Red;
            else if (text.Contains("Warn"))
                textColor = Color.Orange;

            // Draw the text
            TextRenderer.DrawText(
                InEvent.Graphics,
                text,
                InEvent.Font,
                InEvent.Bounds,
                textColor,
                TextFormatFlags.Left
            );

            InEvent.DrawFocusRectangle();

        }
    }
}
