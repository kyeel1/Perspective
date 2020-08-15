using Microsoft.EntityFrameworkCore;
using Perspective.Domain;

namespace Perspective.Storing
{
    public class PerspectiveDBContext :DbContext
    {
       
        public DbSet<UserModel> Users{get;set;}
        public DbSet<MessageModel> Messages{get;set;}
        public DbSet<RoomModel> Rooms{get;set;}
        public DbSet<CatagoryModel> Catagories{get;set;}
        public PerspectiveDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserModel>().HasKey(e => e.Id);
            builder.Entity<CatagoryModel>().HasKey(e => e.Id);
            builder.Entity<MessageModel>().HasKey(e => e.Id);
            builder.Entity<RoomModel>().HasKey(e => e.Id);

        }
    }
}