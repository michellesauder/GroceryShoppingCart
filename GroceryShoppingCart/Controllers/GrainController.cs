using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class GrainController : Controller
    {

        private GroceryCartContext db;
        private IGrainRepository _grainRepo;

        public GrainController(GroceryCartContext db, IGrainRepository grainRepo)
        {
            this.db = db;
            _grainRepo = grainRepo;
        }


        public IActionResult Index()
        {
            var grains = _grainRepo.GrainList();

            return View(grains);
        }
    }
}