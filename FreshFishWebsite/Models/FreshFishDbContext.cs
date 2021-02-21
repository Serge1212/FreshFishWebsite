﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreshFishWebsite.Models
{
    public class FreshFishDbContext : IdentityDbContext<User>
    {
        public FreshFishDbContext(DbContextOptions<FreshFishDbContext> options) : base(options) {}

        public DbSet<StorageAdmin> StorageAdmins { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartProduct> ShoppingCartProducts { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }

    }
}
