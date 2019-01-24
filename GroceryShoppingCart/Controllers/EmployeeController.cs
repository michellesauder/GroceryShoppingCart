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
    public class EmployeeController : Controller
    {
            private GroceryCartContext db;

            public EmployeeController(GroceryCartContext db)
            {
                this.db = db;
            }

            public ActionResult Index()
            {
                EmployeeVMRepo esRepo = new EmployeeVMRepo(db);
                IEnumerable<EmployeeVM> es = esRepo.GetAll();
                return View(es);
            }

        }
    }
