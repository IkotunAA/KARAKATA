using Domain.Entities;
using KARAKATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace KARAKATA.Context
{
    public class KarakataDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Product> Products { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<CartItem> CartItems { get; set; } = default!;

        public KarakataDbContext(DbContextOptions<KarakataDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.Buyer)
                .HasForeignKey(o => o.BuyerId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Products)
                .WithOne(p => p.Seller)
                .HasForeignKey(p => p.SellerId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.CartItems)
                .WithOne(ci => ci.User)
                .HasForeignKey(ci => ci.UserId);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.CartItems)
                .WithOne(ci => ci.Product)
                .HasForeignKey(ci => ci.ProductId);

            // Define other relationships and constraints
        }
    }

}
