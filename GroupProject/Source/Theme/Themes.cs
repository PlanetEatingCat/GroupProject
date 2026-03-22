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

        public static void Initialize()
        {
            Dark = new Theme();
            Dark.Background = Color.Black;
            Dark.Foreground = Color.White;
            Dark.Accent = Color.FromArgb(255, 91, 71, 207);
        }

    }
}
