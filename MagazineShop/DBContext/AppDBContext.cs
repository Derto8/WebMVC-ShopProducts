﻿using MagazineShop.Models;
using MagazineShop.Models.Products;
using Microsoft.EntityFrameworkCore;

namespace MagazineShop.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<TShirt> TShirts { get; set; }
        public DbSet<Candies> Candies { get; set; }
        //public DbSet<Milk> Milk { get; set; }
        public DbSet<ShopProductItem> ShopProductItem { get; set; }
    }
}
