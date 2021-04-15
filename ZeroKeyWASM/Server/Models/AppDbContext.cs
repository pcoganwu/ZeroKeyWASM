using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZeroKeyWASM.Server.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = Guid.NewGuid(), ProductName = "Book", UnitPrice = 12.49m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Music CD", UnitPrice = 14.99m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Chocolate Bar", UnitPrice = 0.85m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Imported Box of Chocolate", UnitPrice = 10.00m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Imported Bottle of Perfume", UnitPrice = 47.50m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Imported Bottle of Perfume", UnitPrice = 27.99m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Bottle of Perfume", UnitPrice = 18.99m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Packet of Headache Pills", UnitPrice = 9.75m },
                new Product { ProductId = Guid.NewGuid(), ProductName = "Imported Box of Chocolate", UnitPrice = 11.25m }
                );
        }
    }
}
