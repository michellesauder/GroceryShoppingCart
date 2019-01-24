using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Models
{
    public class Seeder
    {

        private GroceryCartContext db;
        public Seeder(GroceryCartContext db)
        {
            this.db = db;
            SeedData();
        }

        // This could be modularized more nicely with a repository but here
        // is a basic version of how to seed data.
        public void SeedData()
        {
            // Exit if data exists.
            if (db.Drinks.Count() != 0)
            {
                return;
            }

            //Create a collection of Objects to add to the database.
            Drinks[] seedDrinks = new Drinks[]
            {
                new Drinks { DrinkId = 1, Description = "Milk", Price = 2.50d },
                new Drinks { DrinkId = 2, Description = "Coke", Price = 2.50d },
                new Drinks { DrinkId = 3, Description = "Apple Juice", Price = 1.50d },
                new Drinks { DrinkId = 4, Description = "Orange Juice", Price = 5.50d },
                new Drinks { DrinkId = 5, Description = "Gatorade", Price = 4.60d }
            };

            //AddRange() to add multiple values.
            db.Drinks.AddRange(seedDrinks);


            Fruits[] seedFruit = new Fruits[]
{
                new Fruits { FruitId = 6, Description = "Apple" , Price = 0.50d},
                new Fruits { FruitId = 7, Description = "Orange", Price = 1.50d },
                new Fruits { FruitId = 8, Description = "Banana", Price = 0.60d },
                new Fruits { FruitId = 9, Description = "Pineapple", Price = 0.76d },
                new Fruits { FruitId = 10, Description = "Strawberry", Price = 0.37d }
};

            //AddRange() to add multiple values.
            db.Fruits.AddRange(seedFruit);


            Grain[] seedGrain = new Grain[]
{
                new Grain { GrainId = 11, Description = "Loaf of Bread", Price = 3.12d },
                new Grain { GrainId = 12, Description = "Bagle", Price = 3.42d },
                new Grain { GrainId = 13, Description = "Muffin", Price = 2.12d  },
                new Grain { GrainId = 14, Description = "Pita", Price = 1.43d },
                new Grain { GrainId = 15, Description = "Naan", Price = 7.16d }
};

            //AddRange() to add multiple values.
            db.Grain.AddRange(seedGrain);


            Meat[] seedMeat = new Meat[]
{
                new Meat { MeatId = 16, Description = "Chicken", Price = 13.12d},
                new Meat { MeatId = 17, Description = "Beef", Price = 15.21d },
                new Meat { MeatId = 18, Description = "Duck", Price = 18.34d },
                new Meat { MeatId = 19, Description = "Lamb", Price = 29.42d },
                new Meat { MeatId = 20, Description = "Salmon", Price = 5.12d }
};

            //AddRange() to add multiple values.
            db.Meat.AddRange(seedMeat);


            Vegetables[] seedVegetables = new Vegetables[]
{
                new Vegetables { VegetableId = 21, Description = "Carrot", Price = 3.12d },
                new Vegetables { VegetableId = 22, Description = "Brocolli", Price = 5.12d },
                new Vegetables { VegetableId = 23, Description = "Onion" , Price = 7.12d},
                new Vegetables { VegetableId = 24, Description = "Lettuce", Price = 1.12d },
                new Vegetables { VegetableId = 25, Description = "Spinach", Price = 7.12d }
};

            //AddRange() to add multiple values.
            db.Vegetables.AddRange(seedVegetables);

            Employee[] seedEmployees = new Employee[]
{
                new Employee { EmployeeId = 26, FirstName = "Michelle", LastName = "Sauder", Branch = "Warehouse1" },
                new Employee { EmployeeId = 27, FirstName = "Laura", LastName = "Fash", Branch = "Warehouse2" },
                new Employee { EmployeeId = 28, FirstName = "Darya", LastName = "Shou-awesome", Branch = "Warehouse3" },
                new Employee { EmployeeId = 29, FirstName = "Apollo", LastName = "Sauder", Branch = "Warehouse4" },
                new Employee { EmployeeId = 30, FirstName = "Melissa", LastName = "Fonseka", Branch = "Warehouse5" },
};

            //AddRange() to add multiple values.
            db.Employee.AddRange(seedEmployees);


            Customer[] seedCustomers = new Customer[]
{
                new Customer { CustomerId = 31, FirstName = "Atlas", LastName = "Sauder" },
                new Customer { CustomerId = 32, FirstName = "Enrique", LastName = "Sanchez" },

};

            //AddRange() to add multiple values.
            db.Customer.AddRange(seedCustomers);


            // Commit parent table additions to the database.
            db.SaveChanges();

            /* Add items to the bridge table.
             * Logic used is dependant on the desired seeding values
             * I am adding one record for each seed Technology.
             */
            foreach (Drinks seedDrink in seedDrinks)
            {
                GroceryCart gc = new GroceryCart
                {
                    Drinks = seedDrink
                };
                db.GroceryCart.Add(gc);
            }
            // Commit child table additions to the database.
            db.SaveChanges();


            foreach (Fruits seedFruits in seedFruit)
            {
                GroceryCart gc = new GroceryCart
                {
                    Fruits = seedFruits
                };
                db.GroceryCart.Add(gc);
            }

            db.SaveChanges();


            foreach (Grain seedGrains in seedGrain)
            {
                GroceryCart gc = new GroceryCart
                {
                    Grain = seedGrains
                };
                db.GroceryCart.Add(gc);
            }

            db.SaveChanges();

            foreach (Meat seedMeats in seedMeat)
            {
                GroceryCart gc = new GroceryCart
                {
                    Meat = seedMeats
                };
                db.GroceryCart.Add(gc);
            }

            db.SaveChanges();


            foreach (Vegetables seedVegetable in seedVegetables)
            {
                GroceryCart gc = new GroceryCart
                {
                    Vegetables = seedVegetable
                };
                db.GroceryCart.Add(gc);
            }

            db.SaveChanges();

            foreach (Employee seedEmployee in seedEmployees)
            {
                GroceryCart gc = new GroceryCart
                {
                    Employee = seedEmployee
                };
                db.GroceryCart.Add(gc);
            }

            db.SaveChanges();

            foreach (Customer seedCustomer in seedCustomers)
            {
                GroceryCart gc = new GroceryCart
                {
                    Customer = seedCustomer
                };
                db.GroceryCart.Add(gc);
            }

            db.SaveChanges();



        }
    }
}
