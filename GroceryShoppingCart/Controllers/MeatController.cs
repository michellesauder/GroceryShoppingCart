using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class MeatController : Controller
    {

        private GroceryCartContext db;
        public MeatController(GroceryCartContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
            //var meat = MeatRepo.MeatList();

            return View(db.Meat);
        }
    }
}