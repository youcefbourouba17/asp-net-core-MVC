﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShopingApi.Models;
using ShopingApi.Models.order;
using System.Collections.Generic;

namespace ShopingApi.Data
{
    public class Db_Context : IdentityDbContext<AppUser>
    {
        public Db_Context(DbContextOptions<Db_Context> option) : base(option)
        {

        }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Color> Colors { get;set; }
        public DbSet<Item> Items { get;set; }
        public DbSet<Size> Sizes { get;set; }
        public DbSet<ItemColors> ItemColors { get;set; }
        public DbSet<ItemSizes> ItemSizes { get;set; }

        public DbSet<Order> Orders { get;set; }
        public DbSet<OrderItem> OrderItems { get;set; }
        public DbSet<Shipping> Shippings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure composite key for ItemColors
            modelBuilder.Entity<ItemColors>()
                .HasKey(ic => new { ic.ColorId, ic.ItemID });
            modelBuilder.Entity<OrderItem>()
               .HasKey(ic => new { ic.OrderId, ic.ItemId });

            // Configure relationships
            modelBuilder.Entity<ItemColors>()
                .HasOne(ic => ic.Item)
                .WithMany(i => i.Colors)
                .HasForeignKey(ic => ic.ItemID);

            modelBuilder.Entity<ItemColors>()
                .HasOne(ic => ic.Color)
                .WithMany(c => c.ItemColors)
                .HasForeignKey(ic => ic.ColorId);

            modelBuilder.Entity<OrderItem>()
                .HasOne(ic => ic.Order)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(ic => ic.OrderId);

            // Configure decimal precision for Order.Total_Amount and OrderItem.Price
            modelBuilder.Entity<Order>()
                .Property(o => o.Total_Amount)
                .HasPrecision(18, 2); // Adjust precision as needed

            modelBuilder.Entity<OrderItem>()
                .Property(oi => oi.Price)
                .HasPrecision(18, 2); // Adjust precision as needed

            base.OnModelCreating(modelBuilder);
        }

    }
}