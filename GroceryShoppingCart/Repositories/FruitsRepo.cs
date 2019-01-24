using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class FruitsRepo : IFruitsRepository
    {
        private static List<Fruits> fruits = new List<Fruits> {
        new Fruits { FruitId = 1, Description = "Apples",  Price = 1.50d },
        new Fruits { FruitId = 2, Description = "Bananas", Price = 2.00d }
    };

        public List<Fruits> ProductList()
        {
            return fruits;
        }




    }
}
