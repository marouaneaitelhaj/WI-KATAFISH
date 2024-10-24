using Katafish.Models;
using Microsoft.EntityFrameworkCore;

namespace Katafish.Db
{
    public class KatafishDbContext : DbContext
    {
        public KatafishDbContext(DbContextOptions<KatafishDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } // Abstract class, but EF handles it with TPH (Table-Per-Hierarchy)
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optional: Customize the model (e.g., to map inheritance)
            // modelBuilder.Entity<User>()
            //     .HasDiscriminator<string>("UserType")
            //     .HasValue<Chef>("Chef")
            //     .HasValue<Customer>("Customer")
            //     .HasValue<Receptionist>("Receptionist")
            //     .HasValue<Waiter>("Waiter");
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });
            modelBuilder.Entity<Chef>(entity =>
            {
                entity.ToTable("Chefs");
                entity.HasBaseType<User>();
            });
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customers");
                entity.HasBaseType<User>();
            });
            modelBuilder.Entity<Receptionist>(entity =>
            {
                entity.ToTable("Receptionists");
                entity.HasBaseType<User>();
            });
            modelBuilder.Entity<Waiter>(entity =>
            {
                entity.ToTable("Waiters");
                entity.HasBaseType<User>();
            });
        }
    }
}
