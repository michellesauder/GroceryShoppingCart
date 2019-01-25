using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class MeatRepo : IMeatRepository
    {
        private GroceryCartContext db;
        public MeatRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public List<Meat> MeatList()
        {
            return db.Meat.ToList();
        }
    }
}
