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

        public IEnumerable<Drinks> GetAll(string sortOrder, string searchString)
        {
            IEnumerable<Drinks> drinkSearchSort;

            if (!String.IsNullOrEmpty(searchString))
            {
                drinkSearchSort = db.Drinks.Select(d => new Drinks
                {
                    //DrinkId = d.GroceryCart.Select(di => di.DrinkId),
                    Description = d.Description,
                })
                    .Where(d => d.Description.Contains(searchString));
            }
            else
            {
                drinkSearchSort = db.Drinks.Select(d => new Drinks
                {
                    Description = d.Description

                });
            }


            //var DrinkSort =
            //db.Drinks.Select(d => new Drinks
            //{
            //    Description = d.Description
            //}
            //);

            switch (sortOrder)
            {
                case "description_asc":
                    drinkSearchSort =
                        drinkSearchSort.OrderBy(d => d.Description);
                    break;
                case "title_desc":
                    drinkSearchSort =
                        drinkSearchSort.OrderByDescending(d => d.Description);
                    break;
                case "description_desc":
                    drinkSearchSort =
                  drinkSearchSort.OrderByDescending(d => d.Description);
                    break;
                default:
                    drinkSearchSort =
                        drinkSearchSort.OrderBy(d => d.Description);
                    break;
            };
            return drinkSearchSort;




        }
    }
}
