using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class EmployeeRepo
    {
        private GroceryCartContext db;

        public EmployeeRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public Employee Get(int id)
        {
            return db.Employee.Where(e => e.EmployeeId == id).FirstOrDefault();
        }
    }

}
