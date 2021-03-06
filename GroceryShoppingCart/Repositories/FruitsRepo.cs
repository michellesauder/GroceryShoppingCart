﻿using GroceryShoppingCart.Interfaces;
using GroceryShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class FruitsRepo : IFruitsRepository
    {
        private GroceryCartContext db;
        public FruitsRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public List<Fruits> FruitsList()
        {
            return db.Fruits.ToList();
        }


    }
}
