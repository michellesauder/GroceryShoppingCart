using GroceryShoppingCart.Controllers;
using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;


namespace AppWithTests.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void IndexViewHas5Fruits()
        {
            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                var fruitsRepository = new FruitsRepo(context);
                var controller = new FruitController(context, fruitsRepository);
                int expected = 5;
                var viewResult = Assert.IsType<ViewResult>(controller.Index());
                var model = Assert.IsType<List<Fruits>>(viewResult.Model);
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }
                
        }


        [Fact]
        public void IndexViewHas5Meats()
        {
            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                var meatRepository = new MeatRepo(context);
                var controller = new MeatController(context, meatRepository);
                int expected = 5;
                var viewResult = Assert.IsType<ViewResult>(controller.Index());
                var model = Assert.IsType<List<Meat>>(viewResult.Model);
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }

        }






    }
}
