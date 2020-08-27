using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringApp.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> opt) : base(opt)
        {

        }

        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.Parse("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"),
                    Name = "Sport Cars",
                    Description = "Very Sporty"
                },
                new Category()
                {
                    Id = Guid.Parse("5ade63d4-abf0-4b09-b018-04c99d31f6e1"),
                    Name = "Aeroplane",
                    Description = "Very Flying"
                },
                new Category()
                {
                    Id = Guid.Parse("8bc51e94-bb2f-4f69-bf12-b9b0826d0263"),
                    Name = "Laptop",
                    Description = "Computer i guess"
                },
                new Category()
                {
                    Id = Guid.Parse("b5d459d0-d2e2-403a-b88b-f00fa5a192f9"),
                    Name = "Smart Phone",
                    Description = "Use for making calls and what again?"
                },
                new Category()
                {
                    Id = Guid.Parse("8a6cd291-78d2-4468-bfc5-5c795ffc0c8e"),
                    Name = "Jake",
                    Description = "What is Jake? of course you know Jake"
                });

            builder.Entity<Product>().HasData(
                new Product() 
                {
                    Id = Guid.Parse("ef076389-b608-4d32-ac38-5f3c7c8dca32"),
                    ProductName = "Macbook Pro 13",
                    CategoryId = Guid.Parse("8bc51e94-bb2f-4f69-bf12-b9b0826d0263"),
                    ProductDescription = "Mac Book pro from Apple"
            
                },
                new Product()
                {
                    Id = Guid.Parse("2292b9a7-d37d-49b9-bea9-67fdeb23eac8"),
                    ProductName = "Ferrari Koeniggseg",
                    CategoryId = Guid.Parse("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"),
                    ProductDescription = "This is another fast car for racing, You mean Asphat 9? oh yeah"

                },
                new Product()
                {
                    Id = Guid.Parse("0b779d52-ee94-4870-8b61-6b4bc6ddb41c"),
                    ProductName = "Lamboghini Vandetta",
                    CategoryId = Guid.Parse("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"),
                    ProductDescription = "Its a very fast car, i think"

                },
                new Product()
                {
                    Id = Guid.Parse("717ccd4e-da97-4631-881a-40eb624f6c51"),
                    ProductName = "Samsung Galaxy Mars X",
                    CategoryId = Guid.Parse("b5d459d0-d2e2-403a-b88b-f00fa5a192f9"),
                    ProductDescription = "Never heard of that smartphone, i guess its for alien"

                },
                new Product()
                {
                    Id = Guid.Parse("9242e049-5d69-4cbc-a0c9-4664eb439749"),
                    ProductName = "JAKE SR71 Valkyrie",
                    CategoryId = Guid.Parse("8a6cd291-78d2-4468-bfc5-5c795ffc0c8e"),
                    ProductDescription = "What is that exactly?"
                });

            base.OnModelCreating(builder);
        }
    }
}
