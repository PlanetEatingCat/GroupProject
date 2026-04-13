/********************************************
Name: Themes.cs
Purpose: Default themes for the most exquisite app
Notes: Authored by Daniel
********************************************/


using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public static class Themes
    {
        public static Theme Dark { get; private set; }
        public static Theme SnhuBlue { get; private set; }
        public static Theme Deep { get; private set; }

        public static void Initialize()
        {
            Dark = new Theme();
            Dark.Name = "Dark";
            Dark.Background = Color.FromArgb(19, 7, 68);
            Dark.Surface = Color.FromArgb(34, 13, 84);
            Dark.Active = Color.FromArgb(45, 18, 114);
            Dark.Border = Color.FromArgb(72, 38, 128);
            Dark.Accent = Color.FromArgb(252, 81, 157);
            Dark.Compliment = Color.FromArgb(115, 78, 237);
            Dark.TwinCompliment = Color.FromArgb(128, 128, 255);
            Dark.Sibling = Color.FromArgb(72, 217, 236);
            Dark.SoulAccent = Color.FromArgb(227, 132, 236);
            Dark.Extra = Color.FromArgb(255, 190, 75);
            Dark.Box = Color.FromArgb(74, 53, 124);
            Dark.Text = Color.White;


            SnhuBlue = new Theme();
            SnhuBlue.Name = "SnhuBlue";
            SnhuBlue.Background = Color.FromArgb(185, 209, 234);
            SnhuBlue.Surface = Color.FromArgb(51, 153, 255);
            SnhuBlue.Active = Color.FromArgb(62, 158, 255);
            SnhuBlue.Border = Color.FromArgb(185, 209, 234);
            SnhuBlue.Accent = Color.FromArgb(252, 81, 157);
            SnhuBlue.Compliment = Color.FromArgb(115, 78, 237);
            SnhuBlue.TwinCompliment = Color.FromArgb(128, 128, 255);
            SnhuBlue.Sibling = Color.FromArgb(72, 217, 236);
            SnhuBlue.SoulAccent = Color.FromArgb(227, 132, 236);
            SnhuBlue.Extra = Color.FromArgb(255, 190, 75);
            SnhuBlue.Box = Color.FromArgb(153, 180, 209);
            SnhuBlue.Text = Color.Black;



            Deep = new Theme();
            Deep.Name = "Deep";
            Deep.Background = Color.FromArgb(20, 23, 61);
            Deep.Surface = Color.FromArgb(18, 17, 47);
            Deep.Active = Color.FromArgb(6, 94, 255);
            Deep.Border = Color.FromArgb(20, 23, 61);
            Deep.Accent = Color.FromArgb(6, 94, 255);
            Deep.Compliment = Color.FromArgb(115, 78, 237);
            Deep.TwinCompliment = Color.FromArgb(128, 128, 255);
            Deep.Sibling = Color.FromArgb(72, 217, 236);
            Deep.SoulAccent = Color.FromArgb(227, 132, 236);
            Deep.Extra = Color.FromArgb(255, 190, 75);
            Deep.Box = Color.FromArgb(62, 64, 89);
            Deep.Text = Color.White;
            // Dark.Background;
        }

    }
}
