using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class DrinksController : Controller
    {

        private GroceryCartContext db;
        public DrinksController(GroceryCartContext db)
        {
            this.db = db;
        }
        public IActionResult Index(string sortOrder, string searchString)
        {
            string sort = String.IsNullOrEmpty(sortOrder) ? "title_asc" : sortOrder;
            string search = String.IsNullOrEmpty(searchString) ? "" : searchString;

            ViewData["CurrentSort"] = sort;
            ViewData["CurrentFilter"] = search;

            var drinks = new DrinksRepo(db).GetAll(sort, search);

            return View(drinks);
        }
    }
}