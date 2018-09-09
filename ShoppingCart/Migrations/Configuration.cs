using ShoppingCart.Models;

namespace ShoppingCart.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ShoppingCart.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShoppingCart.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            // Seed Categories
            context.Categories.AddOrUpdate(
                new Category { Name = "Golf" },   
                new Category { Name = "Football" },  
                new Category { Name = "Baseball" }  
            );

            // Seed Products
            context.Products.AddOrUpdate(
                new Product
                {
                    Description = "This driver is the bomb!",
                    Name = "Titleist G-Bomb 500 Driver",
                    InStock = true,
                    Price = 499.99M,
                    Quantity = 3
                }, 
                new Product
                {
                    Description = "These balls offer a great soft feel",
                    Name = "Callaway Chrome Soft Feel Balls",
                    InStock = true,
                    Price = 49.99M,
                    Quantity = 20
                }, 
                new Product
                {
                    Description = "The only glove you need",
                    Name = "Footjoy Golf Glove",
                    InStock = true,
                    Price = 14.99M,
                    Quantity = 50
                }        
            );
        }
    }
}
