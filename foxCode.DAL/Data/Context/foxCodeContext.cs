using foxCode.DAL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foxCode.DAL;

public class foxCodeContext:DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    public foxCodeContext(DbContextOptions<foxCodeContext> options):base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);



        #region Categories
        modelBuilder.Entity<Category>().HasData(

      new Category
      {
          Id = Guid.Parse("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"),
          Name = "Men",
      },
      new Category
      {
          Id = Guid.Parse("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
          Name = "Women",
      },
      new Category
      {
          Id = Guid.Parse("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
          Name = "Kids",
      });
        #endregion

        #region Products Seeding

        var Productss = new List<Product>
        {

        new Product
            {
                Id = Guid.NewGuid(),
                Name = "Men's T-Shirt",
                Description = "Comfortable cotton t-shirt for men",
                Price = 15.99m,
                CategoryID=Guid.Parse("edc6b9e0-9252-4e9d-b4d3-9203b6de2583")
            },
        new Product
            {
                Id = Guid.NewGuid(),
                Name = "Men's Pants",
                Description = "Comfortable cotton t-shirt for men",
                Price = 15.99m,
                  CategoryID=Guid.Parse("edc6b9e0-9252-4e9d-b4d3-9203b6de2583")
            },
        new Product
            {
                Id = Guid.NewGuid(),
                Name = "Men's Jackets",
                Description = "Comfortable cotton t-shirt for men",
                Price = 15.99m,
                  CategoryID=Guid.Parse("edc6b9e0-9252-4e9d-b4d3-9203b6de2583")
            },
        new Product
            {
                Id = Guid.NewGuid(),
                Name = "Men's Shorts",
                Description = "Comfortable cotton t-shirt for men",
                Price = 15.99m,
                  CategoryID=Guid.Parse("edc6b9e0-9252-4e9d-b4d3-9203b6de2583")
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Women's Dress",
                Description = "Elegant dress for women",
                Price = 49.99m,
                CategoryID=Guid.Parse("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
            },
              new Product
            {
                Id = Guid.NewGuid(),
                Name = "Women's Jeans",
                Description = "Elegant dress for women",
                Price = 49.99m,
                CategoryID=Guid.Parse("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),

            },
                new Product
            {
                Id = Guid.NewGuid(),
                Name = "Women's Jackets",
                Description = "Elegant dress for women",
                Price = 49.99m,
                CategoryID=Guid.Parse("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),

            },
                  new Product
            {
                Id = Guid.NewGuid(),
                Name = "Women's Leggings",
                Description = "Elegant dress for women",
                Price = 49.99m,
                CategoryID=Guid.Parse("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),

            },
                    new Product
            {
                Id = Guid.NewGuid(),
                Name = "Women's Swimsuits",
                Description = "Elegant dress for women",
                Price = 49.99m,
                CategoryID=Guid.Parse("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),

            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kids' Shoes",
                Description = "Colorful shoes for kids",
                Price = 29.99m,
                CategoryID=Guid.Parse("52d40b0a-7039-4bc6-899d-0c36adff6b8f")
            },
              new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kids' T-Shirt",
                Description = "Colorful shoes for kids",
                Price = 29.99m,
                CategoryID=Guid.Parse("52d40b0a-7039-4bc6-899d-0c36adff6b8f")

            },
                new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kids' Pants",
                Description = "Colorful shoes for kids",
                Price = 29.99m,
                CategoryID=Guid.Parse("52d40b0a-7039-4bc6-899d-0c36adff6b8f")

            },
                  new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kids' Jackets",
                Description = "Colorful shoes for kids",
                Price = 29.99m,
                CategoryID=Guid.Parse("52d40b0a-7039-4bc6-899d-0c36adff6b8f")

            },
                    new Product
            {
                Id = Guid.NewGuid(),
                Name = "Kids' Shorts",
                Description = "Colorful shoes for kids",
                Price = 29.99m,
                CategoryID=Guid.Parse("52d40b0a-7039-4bc6-899d-0c36adff6b8f")

            },
           


        };

        modelBuilder.Entity<Product>().HasData(Productss);
        #endregion



    }
}
