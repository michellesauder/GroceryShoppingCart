using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class FruitController : Controller
    {

        private GroceryCartContext db;
        public FruitController(GroceryCartContext db)
        {
            this.db = db;
        }


        public IActionResult Index()
        {
           /* var fruits = FruitsRepo.FruitsList();*/



            return View(db.Fruits);
        }
    }
}