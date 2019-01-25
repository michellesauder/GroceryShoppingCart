using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class VegRepo : IVegRepository
    {
        private GroceryCartContext db;
        public VegRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public List<Vegetables> VegList()
        {
            return db.Vegetables.ToList();
        }
    }
}
