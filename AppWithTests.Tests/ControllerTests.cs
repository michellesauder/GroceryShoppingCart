using GroceryShoppingCart.Controllers;
using GroceryShoppingCart.Interfaces;
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

        [Fact]
        public void IndexViewHas5Veggies()
        {
            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                var veggiesRepository = new VegRepo(context);
                var controller = new VegetablesController(context, veggiesRepository);
                int expected = 5;
                var viewResult = Assert.IsType<ViewResult>(controller.Index());
                var model = Assert.IsType<List<Vegetables>>(viewResult.Model);
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }

        }

        [Fact]
        public void UnitTestFruitList()
        {

            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                // 1. Create instance of fake repo using IProductRepository interface.
                var mockFruitsRepo = new Mock<IFruitsRepository>();

                // 2. Set up return data for ProductList() method.
                mockFruitsRepo.Setup(mpr => mpr.FruitsList())
                    .Returns(new List<Fruits>{
                    new Fruits(), new Fruits(), new Fruits()
                    });

                // 3. Define controller instance with mock repository instance.
                var controller = new FruitController(context, mockFruitsRepo.Object);

                // 4. Make your test Assertions 
                // Check if it returns a view
                var result = Assert.IsType<ViewResult>(controller.Index());

                // Check that the model returned to the view is 'List<Product>'.
                var model = Assert.IsType<List<Fruits>>(result.Model);

                // Ensure count of objects is 3.
                int expected = 3;
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }
        }


        [Fact]
        public void UnitTestMeatList()
        {

            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                // 1. Create instance of fake repo using IProductRepository interface.
                var mockMeatRepo = new Mock<IMeatRepository>();

                // 2. Set up return data for ProductList() method.
                mockMeatRepo.Setup(mpr => mpr.MeatList())
                    .Returns(new List<Meat>{
                    new Meat(), new Meat(), new Meat()
                    });

                // 3. Define controller instance with mock repository instance.
                var controller = new MeatController(context, mockMeatRepo.Object);

                // 4. Make your test Assertions 
                // Check if it returns a view
                var result = Assert.IsType<ViewResult>(controller.Index());

                // Check that the model returned to the view is 'List<Product>'.
                var model = Assert.IsType<List<Meat>>(result.Model);

                // Ensure count of objects is 3.
                int expected = 3;
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }
        }


        [Fact]
        public void UnitTestVegList()
        {

            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                // 1. Create instance of fake repo using IProductRepository interface.
                var mockVegRepo = new Mock<IVegRepository>();

                // 2. Set up return data for ProductList() method.
                mockVegRepo.Setup(mpr => mpr.VegList())
                    .Returns(new List<Vegetables>{
                    new Vegetables(), new Vegetables(), new Vegetables()
                    });

                // 3. Define controller instance with mock repository instance.
                var controller = new VegetablesController(context, mockVegRepo.Object);

                // 4. Make your test Assertions 
                // Check if it returns a view
                var result = Assert.IsType<ViewResult>(controller.Index());

                // Check that the model returned to the view is 'List<Product>'.
                var model = Assert.IsType<List<Vegetables>>(result.Model);

                // Ensure count of objects is 3.
                int expected = 3;
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }
        }


        [Fact]
        public void UnitTestGrainList()
        {

            using (var context = new GroceryCartContext(DbOptionsFactory.DbContextOptions))
            {
                // 1. Create instance of fake repo using IProductRepository interface.
                var mockGrainRepo = new Mock<IGrainRepository>();

                // 2. Set up return data for ProductList() method.
                mockGrainRepo.Setup(mpr => mpr.GrainList())
                    .Returns(new List<Grain>{
                    new Grain(), new Grain(), new Grain()
                    });

                // 3. Define controller instance with mock repository instance.
                var controller = new GrainController(context, mockGrainRepo.Object);

                // 4. Make your test Assertions 
                // Check if it returns a view
                var result = Assert.IsType<ViewResult>(controller.Index());

                // Check that the model returned to the view is 'List<Product>'.
                var model = Assert.IsType<List<Grain>>(result.Model);

                // Ensure count of objects is 3.
                int expected = 3;
                int actual = model.Count;
                Assert.Equal(expected, actual);
            }
        }























    }
}
