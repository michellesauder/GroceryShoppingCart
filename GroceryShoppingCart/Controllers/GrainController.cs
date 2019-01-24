using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class GrainController : Controller
    {

        private GroceryCartContext db;
        public GrainController(GroceryCartContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View(db.Grain);
        }
    }
}