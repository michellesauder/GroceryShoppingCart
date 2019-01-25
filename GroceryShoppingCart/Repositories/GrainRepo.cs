using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class GrainRepo : IGrainRepository
    {
        private GroceryCartContext db;
        public GrainRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public List<Grain> GrainList()
        {
            return db.Grain.ToList();
        }
    }
}
