using GroceryShoppingCart.Controllers;
using GroceryShoppingCart.Models;
using GroceryShoppingCart.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;


namespace AppWithTests.Tests
{
    public class ControllerTests
    {
        [Fact]
        public void IndexViewHas2Fruits()
        {
            var fruitsRepository = new FruitsRepo();
            var controller = new HomeController(fruitsRepository);
            int expected = 2;
            var viewResult = Assert.IsType<ViewResult>(controller.Index());
            var model = Assert.IsType<List<Fruits>>(viewResult.Model);
            int actual = model.Count;
            Assert.Equal(expected, actual);
        }

    }
}
