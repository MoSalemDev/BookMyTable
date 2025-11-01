using BookMyTable.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMyTable.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
        public DbSet<Tables> Tables { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<Menus> Menus { get; set; }
        public DbSet<RestaurantTypes> RestaurantTypes { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Notifications> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
