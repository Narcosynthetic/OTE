using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTE
{
    public static class Helpers
    {
        public static DateTime GetDefaultDate()
        {
            DateTime defaultDate = new DateTime(1900, 1, 1);
            return defaultDate;
        }

        public static bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }
    }

    public static class Enums
    {
        public enum UserRoles
        {
            none = 0,
            Administrator = 1,
            Supervisor = 2,
            Technician = 3
        }
        public enum SavingMode
        {
            none = 0,
            Insert = 1,
            Update = 2
        }

    }
}
