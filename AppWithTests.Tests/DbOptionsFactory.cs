using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GroceryShoppingCart.Models;
using System.IO;


namespace AppWithTests.Tests
{
    class DbOptionsFactory
    {
        static DbOptionsFactory()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Path.GetFullPath("../../../")))
                .AddJsonFile("testsettings.json", optional: false, reloadOnChange: true)
                .Build();
            var connectionString = config["ConnectionStrings:DefaultConnection"];

            DbContextOptions = new DbContextOptionsBuilder<GroceryCartContext>()
                .UseSqlServer(connectionString)
                .Options;
        }

        public static DbContextOptions<GroceryCartContext> DbContextOptions { get; }

    }
}
