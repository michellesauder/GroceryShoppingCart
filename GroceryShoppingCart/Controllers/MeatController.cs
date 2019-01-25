using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class MeatController : Controller
    {

        private GroceryCartContext db;
        private IMeatRepository _meatRepo;

        public MeatController(GroceryCartContext db, IMeatRepository meatRepo)
        {
            this.db = db;
            _meatRepo = meatRepo;
        }


        public IActionResult Index()
        {
            var meat = _meatRepo.MeatList();

            return View(meat);
        }
    }
}
