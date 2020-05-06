using System;
using System.Data.Entity;

namespace PIS_Storage
{
    public class PIS_DbContext : DbContext
    {
        public PIS_DbContext() : base("DbConnectionString")
        {
           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Storage> Storage { get; set; }
        public DbSet<OrderStatusChange> OrderStatusChanges { get; set; }
        public DbSet<GoodType> GoodTypes { get; set; }
    }
}
