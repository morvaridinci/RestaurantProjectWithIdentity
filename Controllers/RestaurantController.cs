using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantProjectWithIdentity.Data;
using static RestaurantProjectWithIdendity.Enum.EnumRoles;

namespace RestaurantProjectWithIdendity.Controllers
{
     [Authorize(Roles="Admin")]
    public class RestaurantController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public RestaurantController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult GetList()
        {
            var result = _applicationDbContext.Restaurants.ToList();
            return View(result);
        }
    }
}
