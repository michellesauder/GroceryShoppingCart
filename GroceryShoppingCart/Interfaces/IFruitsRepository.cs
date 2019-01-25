using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Interfaces
{
    public interface IFruitsRepository
    {
        List<Fruits> FruitsList();
    }
}
