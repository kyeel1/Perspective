using Microsoft.EntityFrameworkCore;
using Perspective.Domain.Models;

namespace Perspective.Storing
{
    public class PizzaStoreDBContext :DbContext
    {
        public DbSet<PizzaModel> Pizzas {get;set;}
        public DbSet<UserModel> Users{get;set;}
        public DbSet<StoreModel> Stores{get;set;}
        public DbSet<OrderModel> Orders{get;set;}
        public DbSet<SizeModel> Sizes{get;set;}
        public DbSet<ToppingsModel> Toppings{get;set;}
        public DbSet<CrustModel> Crusts{get;set;}
        public PizzaStoreDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PizzaModel>().HasKey(e => e.Id);
            builder.Entity<CrustModel>().HasKey(e => e.Id);
            builder.Entity<SizeModel>().HasKey(e => e.Id);
            builder.Entity<ToppingsModel>().HasKey(e => e.Id);
            builder.Entity<UserModel>().HasKey(e => e.Id);
            builder.Entity<StoreModel>().HasKey(e => e.Id);
            builder.Entity<OrderModel>().HasKey(e => e.Id);

        }
    }
}