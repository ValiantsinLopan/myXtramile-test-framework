using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Tools
{
    public static class NameGenerator
    {
        public static String CurrentDateTime()
        {
            return $"Automation_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}";
        }
        public static String EmailAsCurrentDateTime(string email)
        {
            return $"Automation_{DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss")}@mailinator.com";
        }
    }

}
