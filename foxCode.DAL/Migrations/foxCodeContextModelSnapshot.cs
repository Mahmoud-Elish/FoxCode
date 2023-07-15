﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using foxCode.DAL;

#nullable disable

namespace foxCode.DAL.Migrations
{
    [DbContext(typeof(foxCodeContext))]
    partial class foxCodeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("foxCode.DAL.Data.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"),
                            Name = "Men"
                        },
                        new
                        {
                            Id = new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
                            Name = "Women"
                        },
                        new
                        {
                            Id = new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
                            Name = "Kids"
                        });
                });

            modelBuilder.Entity("foxCode.DAL.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae35e72a-4e57-451a-8146-0a54595ee82b"),
                            CategoryID = new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"),
                            Description = "Comfortable cotton t-shirt for men",
                            Name = "Men's T-Shirt",
                            Price = 15.99m
                        },
                        new
                        {
                            Id = new Guid("e3581857-9328-404b-872c-7d4128bd5158"),
                            CategoryID = new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"),
                            Description = "Comfortable cotton t-shirt for men",
                            Name = "Men's Pants",
                            Price = 15.99m
                        },
                        new
                        {
                            Id = new Guid("1856ec62-4ea0-4cad-aa6f-05492bbaa138"),
                            CategoryID = new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"),
                            Description = "Comfortable cotton t-shirt for men",
                            Name = "Men's Jackets",
                            Price = 15.99m
                        },
                        new
                        {
                            Id = new Guid("f657e27b-4000-419a-94f6-770d24cc4952"),
                            CategoryID = new Guid("edc6b9e0-9252-4e9d-b4d3-9203b6de2583"),
                            Description = "Comfortable cotton t-shirt for men",
                            Name = "Men's Shorts",
                            Price = 15.99m
                        },
                        new
                        {
                            Id = new Guid("16a66462-1880-4d3b-8750-1104f62eaaac"),
                            CategoryID = new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
                            Description = "Elegant dress for women",
                            Name = "Women's Dress",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = new Guid("984775d6-57a7-4330-867e-6275067c4f20"),
                            CategoryID = new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
                            Description = "Elegant dress for women",
                            Name = "Women's Jeans",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = new Guid("917f4d1d-8451-4775-a3cd-5ff4e66067d9"),
                            CategoryID = new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
                            Description = "Elegant dress for women",
                            Name = "Women's Jackets",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = new Guid("bf58f84e-8802-44d2-bdc9-a0cae047b460"),
                            CategoryID = new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
                            Description = "Elegant dress for women",
                            Name = "Women's Leggings",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = new Guid("046493c5-3688-4d10-833f-4e0f8b872d18"),
                            CategoryID = new Guid("a6c4de53-33c5-48e1-9f21-5649726d2a3d"),
                            Description = "Elegant dress for women",
                            Name = "Women's Swimsuits",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = new Guid("d867ec5f-ac65-4610-8baf-f6f512dfd642"),
                            CategoryID = new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
                            Description = "Colorful shoes for kids",
                            Name = "Kids' Shoes",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = new Guid("6f9a5461-2b0a-44a0-88a5-f9ca94463764"),
                            CategoryID = new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
                            Description = "Colorful shoes for kids",
                            Name = "Kids' T-Shirt",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = new Guid("8fd85c1b-a6a9-4cfb-9224-095523e82b7a"),
                            CategoryID = new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
                            Description = "Colorful shoes for kids",
                            Name = "Kids' Pants",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = new Guid("2e7bee36-bcfc-4265-a875-f4cde38deaf0"),
                            CategoryID = new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
                            Description = "Colorful shoes for kids",
                            Name = "Kids' Jackets",
                            Price = 29.99m
                        },
                        new
                        {
                            Id = new Guid("d2506798-c1da-41fc-a6ff-0e74d20ff250"),
                            CategoryID = new Guid("52d40b0a-7039-4bc6-899d-0c36adff6b8f"),
                            Description = "Colorful shoes for kids",
                            Name = "Kids' Shorts",
                            Price = 29.99m
                        });
                });

            modelBuilder.Entity("foxCode.DAL.Product", b =>
                {
                    b.HasOne("foxCode.DAL.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("foxCode.DAL.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
