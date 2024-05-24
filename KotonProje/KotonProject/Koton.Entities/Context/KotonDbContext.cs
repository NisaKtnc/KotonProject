using Koton.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koton.Entities.Context
{
    public class KotonDbContext : DbContext
    {
        protected KotonDbContext()
        {
        }
        public KotonDbContext(DbContextOptions<KotonDbContext> options) : base(options)
        {            
        }
        
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Customers> Customer { get; set; }
        public DbSet<Order_details> Order_detail { get; set; }
        public DbSet<Orders> Order { get; set; }
        public DbSet<OrderType> OrderTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<Reviews> Review { get; set; }
        public DbSet<Size> Sizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Orders>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Order)
            .HasForeignKey(o => o.CustomersId);

            modelBuilder.Entity<Orders>()
            .HasOne(o => o.Payments)
            .WithMany(c => c.Order)
            .HasForeignKey(o => o.PaymentId);

            modelBuilder.Entity<Cart>()
            .HasOne(o => o.Product)
            .WithMany(c => c.Carts)
            .HasForeignKey(o => o.ProductsId);

            modelBuilder.Entity<Cart>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Carts)
            .HasForeignKey(o => o.CustomersId);

            modelBuilder.Entity<Products>()
            .HasOne(o => o.Category)
            .WithMany(c => c.Product)
            .HasForeignKey(o => o.CategoriesId);

            modelBuilder.Entity<Products>()
            .HasOne(o => o.Sizes)
            .WithMany(c => c.Product)
            .HasForeignKey(o => o.SizeId);

            modelBuilder.Entity<Reviews>()
            .HasOne(o => o.Product)
            .WithMany(c => c.Review)
            .HasForeignKey(o => o.ProductsId);

            modelBuilder.Entity<Order_details>()
            .HasOne(o => o.Product)
            .WithMany(c => c.OrderDetails)
            .HasForeignKey(o => o.ProductsId);

            modelBuilder.Entity<Order_details>()
            .HasOne(o => o.Order)
            .WithMany(c => c.OrderDetails)
            .HasForeignKey(o => o.OrderId);

            modelBuilder.Entity<OrderType>()
            .HasOne(o => o.Orders)
            .WithMany(c => c.OrderTypes)
            .HasForeignKey(o => o.OrdersId);

            modelBuilder.Entity<Reviews>()
            .HasOne(o => o.Customer)
            .WithMany(c => c.Review)
            .HasForeignKey(o => o.CustomersId);
        }


    }
}
