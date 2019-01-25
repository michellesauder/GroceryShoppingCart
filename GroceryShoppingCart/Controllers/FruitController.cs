using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class FruitController : Controller
    {

        private GroceryCartContext db;
        private IFruitsRepository _fruitRepo;

        public FruitController(GroceryCartContext db, IFruitsRepository fruitRepo)
        {
            this.db = db;
            _fruitRepo = fruitRepo;
        }


        public IActionResult Index()
        {
            var fruits = _fruitRepo.FruitsList();

            return View(fruits);
        }
    }
}