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
        public void IndexViewHas2Fruits()
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

    //    using (var context = new YourContext(DbOptionsFactory.DbContextOptions))
    //{
    //    // Instantiate Class with DbContext parameter
    //    var controller = new YourController(context);

    //// Act
    //var result = await controller.Index();

    //// Assert
    //var viewResult = Assert.IsType<ViewResult>(result);
    //var model = Assert.IsAssignableFrom<IEnumerable<Model>>(viewResult.Model);
    //int expected = 3;
    //Assert.Equal(expected, model.Count());
    //}


[Fact]
        public void UnitTestFruitsList()
        {
            // 1. Create instance of fake repo using IProductRepository interface.
            //var mockFruitsRepo = new Mock<GroceryShoppingCart.Interfaces.IFruitsRepository>();

            //// 2. Set up return data for ProductList() method.
            //mockFruitsRepo.Setup(mpr => mpr.FruitsList())
            //    .Returns(new List<Fruits>{
            //        new Fruits(), new Fruits(), new Fruits()
            //    });

            //// 3. Define controller instance with mock repository instance.
            //var controller = new FruitController( db,mockFruitsRepo.Object);

            //// 4. Make your test Assertions 
            //// Check if it returns a view
            //var result = Assert.IsType<ViewResult>(controller.Index());

            //// Check that the model returned to the view is 'List<Product>'.
            //var model = Assert.IsType<List<Fruits>>(result.Model);

            //// Ensure count of objects is 3.
            //int expected = 3;
            //int actual = model.Count;
            //Assert.Equal(expected, actual);
        }






    }
}
