using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantProjectWithIdendity.Enum
{
    public static class EnumRoles
    {
        public static class Roles
        {
            public const string Admin = "Admin";
        }

        public enum RoleTypes : byte
        {
            [Description(Roles.Admin)]
            Admin = 1
        }
    }
}
