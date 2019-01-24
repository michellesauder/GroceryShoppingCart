using GroceryShoppingCart.Models;
using GroceryShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Repositories
{
    public class DrinksRepo
    {

        private GroceryCartContext db;

        public DrinksRepo(GroceryCartContext db)
        {
            this.db = db;
        }

        public IQueryable<Drinks> GetAll(string sortOrder, string searchString)
        {
            IQueryable<Drinks> drinkSearch;
            if (!String.IsNullOrEmpty(searchString))
            {
                drinkSearch = db.Drinks.Select(d => new Drinks
                {
                    Description = d.Description,
                })
                    .Where(d => d.Description.Contains(searchString));
            }
            else
            {
                drinkSearch = db.Drinks.Select(d => new Drinks
                {
                    Description = d.Description

                });
            }


            var DrinkSort =
            db.Drinks.Select(d => new Drinks
            {
                Description = d.Description
            }
            );

            switch (sortOrder)
            {
                case "description_asc":
                    DrinkSort =
                        DrinkSort.OrderBy(d => d.Description);
                    break;
                case "title_desc":
                    DrinkSort =
                        DrinkSort.OrderByDescending(d => d.Description);
                    break;
                case "description_desc":
                    DrinkSort =
                  DrinkSort.OrderByDescending(d => d.Description);
                    break;
                default:
                    DrinkSort =
                        DrinkSort.OrderBy(d => d.Description);
                    break;
            };
            return DrinkSort;
        }
    }
}
