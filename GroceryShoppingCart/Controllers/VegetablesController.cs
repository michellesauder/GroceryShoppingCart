using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class VegetablesController : Controller
    {

        private GroceryCartContext db;
        private IVegRepository _vegRepo;

        public VegetablesController(GroceryCartContext db, IVegRepository vegRepo)
        {
            this.db = db;
            _vegRepo = vegRepo;
        }


        public IActionResult Index()
        {
            var veg = _vegRepo.VegList();

            return View(veg);
        }
    }
}
