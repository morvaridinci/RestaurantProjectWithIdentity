using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantProjectWithIdendity.Models
{
    public class Menu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
