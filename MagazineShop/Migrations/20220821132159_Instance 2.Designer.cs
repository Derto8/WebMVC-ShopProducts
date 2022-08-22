﻿// <auto-generated />
using System;
using MagazineShop.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MagazineShop.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220821132159_Instance 2")]
    partial class Instance2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MagazineShop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MagazineShop.Models.ShopProductItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShowProductId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ShopProductItem");
                });

            modelBuilder.Entity("MagazineShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Spend")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MagazineShop.Models.Products.Candies", b =>
                {
                    b.HasBaseType("MagazineShop.Models.Product");

                    b.Property<string>("Candy")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Candies");
                });

            modelBuilder.Entity("MagazineShop.Models.Products.Milk", b =>
                {
                    b.HasBaseType("MagazineShop.Models.Product");

                    b.Property<string>("MilkName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Milk");
                });

            modelBuilder.Entity("MagazineShop.Models.Products.TShirt", b =>
                {
                    b.HasBaseType("MagazineShop.Models.Product");

                    b.Property<string>("TShirtDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TShirtName")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("TShirts");
                });

            modelBuilder.Entity("MagazineShop.Models.ShopProductItem", b =>
                {
                    b.HasOne("MagazineShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MagazineShop.Models.Products.Candies", b =>
                {
                    b.HasOne("MagazineShop.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("MagazineShop.Models.Products.Candies", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MagazineShop.Models.Products.Milk", b =>
                {
                    b.HasOne("MagazineShop.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("MagazineShop.Models.Products.Milk", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MagazineShop.Models.Products.TShirt", b =>
                {
                    b.HasOne("MagazineShop.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("MagazineShop.Models.Products.TShirt", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
