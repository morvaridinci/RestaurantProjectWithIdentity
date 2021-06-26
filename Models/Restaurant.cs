using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantProjectWithIdendity.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Menu> Menus { get; set; }
    }
}
