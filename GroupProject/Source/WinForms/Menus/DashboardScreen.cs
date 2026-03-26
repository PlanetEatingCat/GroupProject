using ScottPlot;
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
    public partial class DashboardScreen : UserControl
    {
        public DashboardScreen()
        {
            InitializeComponent();
        }

        private void DashboardScreen_Load(object InSender, EventArgs InEvent)
        {
            ScreenManager.HostForm.SetMenuBarActive(true);

            ScreenManager.SetRightMenuBar(new RightMenuBar());

            {
                List<PieSlice> slices =
                [
                   new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Netflix", LegendText = "R" },
                new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Hulu" },
                new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Housing" },
                new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Gas", LegendText = "G" },
                new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Travel", LegendText = "B" },
            ];

                var pie = formsPlot1.Plot.Add.Pie(slices);
                pie.ExplodeFraction = .1;
                pie.SliceLabelDistance = 1.4;

                formsPlot1.Plot.ShowLegend();

                // hide unnecessary plot components
                formsPlot1.Plot.Axes.Frameless();
                formsPlot1.Plot.HideGrid();

                formsPlot1.Refresh();
            }

            {
                List<PieSlice> slices =
                [
                   new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Netflix", LegendText = "R" },
                new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Hulu" },
                new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Housing" },
                new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Gas", LegendText = "G" },
                new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Travel", LegendText = "B" },
            ];

                var pie = formsPlot2.Plot.Add.Pie(slices);
                pie.ExplodeFraction = .1;
                pie.SliceLabelDistance = 1.4;

                formsPlot2.Plot.ShowLegend();

                // hide unnecessary plot components
                formsPlot2.Plot.Axes.Frameless();
                formsPlot2.Plot.HideGrid();

                formsPlot2.Refresh();
            }

            {
                List<PieSlice> slices =
                [
                    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Netflix", LegendText = "R" },
                    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Hulu" },
                    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Housing" },
                    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Gas", LegendText = "G" },
                    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Travel", LegendText = "B" },
                ];

                var pie = formsPlot3.Plot.Add.Pie(slices);
                pie.ExplodeFraction = .1;
                pie.SliceLabelDistance = 1.4;

                formsPlot3.Plot.ShowLegend();

                // hide unnecessary plot components
                formsPlot3.Plot.Axes.Frameless();
                formsPlot3.Plot.HideGrid();

                formsPlot3.Refresh();
            }
        }
    }
}
