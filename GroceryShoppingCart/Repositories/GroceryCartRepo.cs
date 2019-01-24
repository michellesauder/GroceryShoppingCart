using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class GroceryCart
    {
        private GroceryCartContext db;

        public GroceryCart(GroceryCartContext db)
        {
            this.db = db;
        }


        //how to pull employee by Id. Not working.

        //public GroceryCart Get(int emId)
        //{
        //    return db.GroceryCart.Where(s => s.EmployeeId == emId).FirstOrDefault();
        //}

    }

}
