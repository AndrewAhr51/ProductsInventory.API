using Microsoft.EntityFrameworkCore;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;

namespace ProductsInventory.API.DbContexts
{
    public class ProductsContext : DbContext
    {

        public ProductsContext(DbContextOptions<ProductsContext> options)
           : base(options)
        {
        }

        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed the database with dummy data
            modelBuilder.Entity<Products>().HasData(
                new Products()
                {
                    productId = 1,
                    productName = "Leaf Rake",
                    productCode = "GDN-0011",
                    releaseDate = "March 19, 2019",
                    description = "Leaf rake with 48-inch wooden handle.",
                    price = 19.95M,
                    starRating = 3.2M,
                    imageUrl = "assets/images/leaf_rake.png"

                },
                new Products()
                {
                    productId = 2,
                    productName = "Garden Cart",
                    productCode = "GDN-0023",
                    releaseDate = "March 28, 2019",
                    description = "5 gallon capacity rolling garden cart",
                    price = 32.99M,
                    starRating = 4.2M,
                    imageUrl = "assets/images/garden_cart.png"

                },
                new Products()
                {
                    productId = 3,
                    productName = "Hammer",
                    productCode = "TBX-0048",
                    releaseDate = "May 21, 2019",
                    description = "Curved claw steel hammer",
                    price = 8.99M,
                    starRating = 4.8M,
                    imageUrl = "assets/images/hammer.png"

                },
                new Products()
                {
                    productId = 4,
                    productName = "Saw",
                    productCode = "TBX-0022",
                    releaseDate = "May 15, 2019",
                    description = "5-inch steel blade hand saw",
                    price = 11.55M,
                    starRating = 3.7M,
                    imageUrl = "assets/images/saw.png"
                },
                new Products()
                {
                    productId = 5,
                    productName = "Video Game Controller",
                    productCode = "GMG-0042",
                    releaseDate = "October 15, 2018",
                    description = "tandard two-button video game controller",
                    price = 35.95M,
                    starRating = 4.6M,
                    imageUrl = "assets/images/xbox-controller.png"
                }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
