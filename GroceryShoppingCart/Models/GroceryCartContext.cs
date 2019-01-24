using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShoppingCart.Models
{
        public class GroceryCartContext : DbContext
        {
            public GroceryCartContext(DbContextOptions<GroceryCartContext> options)
                : base(options)
            { }

            public DbSet<Drinks> Drinks { get; set; }
            public DbSet<Fruits> Fruits { get; set; }
            public DbSet<Vegetables> Vegetables { get; set; }
            public DbSet<Grain> Grain { get; set; }
            public DbSet<Meat> Meat { get; set; }
            public DbSet<Employee> Employee { get; set; }
            public DbSet<Customer> Customer { get; set; }
            public DbSet<NewClient> NewClient { get; set; }
            public DbSet<OrderRequest> OrderRequest { get; set; }








        public DbSet<GroceryCart> GroceryCart { get; set; }


            // override of parent DbContext's virtual method.
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Define bridge table's composite primary key.
                modelBuilder.Entity<GroceryCart>()
                    .HasKey(gc => new { gc.DrinkId, gc.MeatId, gc.VegetableId, gc.FruitId, gc.GrainId, gc.EmployeeId, gc.CustomerId });


            modelBuilder.Entity<GroceryCart>()
              .HasOne(gc => gc.Drinks)
              .WithMany(gc => gc.GroceryCart)
              .HasForeignKey(fk => new { fk.DrinkId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            // Define bridge table's foreign keys.
            modelBuilder.Entity<GroceryCart>()
                  .HasOne(gc => gc.Meat)
                  .WithMany(gc => gc.GroceryCart)
                  .HasForeignKey(fk => new { fk.MeatId })
                  .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete


            modelBuilder.Entity<GroceryCart>()
              .HasOne(gc => gc.Vegetables)
              .WithMany(gc => gc.GroceryCart)
              .HasForeignKey(fk => new { fk.VegetableId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete


            modelBuilder.Entity<GroceryCart>()
              .HasOne(gc => gc.Fruits)
              .WithMany(gc => gc.GroceryCart)
              .HasForeignKey(fk => new { fk.FruitId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete


            modelBuilder.Entity<GroceryCart>()
              .HasOne(gc => gc.Grain)
              .WithMany(gc => gc.GroceryCart)
              .HasForeignKey(fk => new { fk.GrainId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

             modelBuilder.Entity<GroceryCart>()
              .HasOne(gc => gc.Employee)
              .WithMany(gc => gc.GroceryCart)
              .HasForeignKey(fk => new { fk.EmployeeId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

             modelBuilder.Entity<GroceryCart>()
              .HasOne(gc => gc.Customer)
              .WithMany(gc => gc.GroceryCart)
              .HasForeignKey(fk => new { fk.CustomerId })
              .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

        }

        }
    }

