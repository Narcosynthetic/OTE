using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTE
{
    public static class Helpers
    {
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
