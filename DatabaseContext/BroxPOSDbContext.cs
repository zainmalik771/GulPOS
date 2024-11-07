using BroxPOSBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace BroxPOSBackend.DatabseContext
{
    public class BroxPOSDbContext : DbContext
    {
        public BroxPOSDbContext(DbContextOptions<BroxPOSDbContext> options) : base(options)
        {
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuring relationships
            modelBuilder.Entity<Item>()
                .HasOne(i => i.Order)             // Each Item has one Order
                .WithMany(o => o.Items)          // Each Order has many Items
                .HasForeignKey(i => i.OrderId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
