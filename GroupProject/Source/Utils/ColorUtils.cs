/********************************************
Name: ColorUtils.cs
Purpose: Utilities for dealing with Colors
Notes: Authored by Daniel
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public static class ColorUtils
    {
        public static Color GetContrastColor(Color InBackground)
        {
            int brightness = (int)((InBackground.R * 0.299) + (InBackground.G * 0.587) + (InBackground.B * 0.114));

            return brightness > 128 ? Color.Black : Color.White;
        }
    }
}
