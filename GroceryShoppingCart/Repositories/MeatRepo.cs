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
        private static List<Meat> meat = new List<Meat> {
        new Meat { MeatId = 1, Description = "Lamb",  Price = 1.50d },
        new Meat { MeatId = 2, Description = "Cod", Price = 2.00d }
    };

        public List<Meat> MeatList()
        {
            return meat;
        }
    }
}
