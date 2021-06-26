using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestaurantProjectWithIdendity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantProjectWithIdentity.Data;

namespace RestaurantProjectWithIdendity.Controllers
{
    [Authorize(Roles="Admin")]
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public MenuController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [AllowAnonymous]
        public IActionResult GetMenu()
        {
            var result = _applicationDbContext.Menus.ToList();
            return View(result);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Add(Menu model)
        {
            _applicationDbContext.Menus.Add(model);
            _applicationDbContext.SaveChanges();
            return RedirectToAction("GetList");
        }
    }
}
