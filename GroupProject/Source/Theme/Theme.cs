/********************************************
Name: Theme.cs
Purpose: Theme for the most exquisite app
Notes: WIP
********************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{
    public enum ThemeColorElement
    {
        Background,
        Surface,
        Accent,
        Compliment,
        TwinCompliment,
        Sibling,
        Extra,
        SoulAccent,
        Border,
        Active,
    }

    public class Theme
    {
        public string Name;
        public Color Background;
        public Color Surface;
        public Color Text;
        public Color Accent;
        public Color Compliment;
        public Color TwinCompliment;
        public Color Sibling;
        public Color Extra;
        public Color SoulAccent;
        public Color Border;
        public Color Active;
        public Color DefaultFontColor;

        public Font DefaultFont;
        public Font TitleFont;

        public Theme Clone()
        {
            return new Theme
            {
                Background = this.Background,
                Surface = this.Surface,
                Text = this.Text,
                Accent = this.Accent,
                Compliment = this.Compliment,
                TwinCompliment = this.TwinCompliment,
                Sibling = this.Sibling,
                Extra = this.Extra,
                SoulAccent = this.SoulAccent,
                Border = this.Border,
                Active = this.Active,
            };
        }

    }
}
