using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantProjectWithIdentity.Models
{
    public class UserViewModel: IdentityUser
    {
        public string FirstName { get; set; }
        public string TC { get; set; }
        public string Password { get; set; }
    }
}
