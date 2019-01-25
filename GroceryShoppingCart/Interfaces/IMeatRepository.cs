using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Interfaces
{
    public interface IMeatRepository
    {
        List<Meat> MeatList();
    }
}
