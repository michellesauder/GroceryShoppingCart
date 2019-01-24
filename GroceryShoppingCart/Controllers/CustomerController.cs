using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using GroceryShoppingCart.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShoppingCart.Controllers
{
    public class CustomerController : Controller
    {
        private GroceryCartContext db;

        public CustomerController(GroceryCartContext db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            CustomerVMRepo esRepo = new CustomerVMRepo(db);
            IEnumerable<CustomerVM> es = esRepo.GetAll();
            return View(es);
        }

    }
}