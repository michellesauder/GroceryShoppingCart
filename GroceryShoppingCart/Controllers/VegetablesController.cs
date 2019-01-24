using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class VegetablesController : Controller
    {

        private GroceryCartContext db;
        public VegetablesController(GroceryCartContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Vegetables);
        }
    }
}