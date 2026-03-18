using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanner
{

    public static class Session
    {
        public static Profile ActiveProfile { get; private set; }

        public static void SetActive(Profile profile)
        {
            ActiveProfile = profile;
        }

        public static bool HasActive() { return ActiveProfile != null; }
    }
}
