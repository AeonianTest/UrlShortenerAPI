using Microsoft.EntityFrameworkCore;
using UrlShortenerAPI.Models;

/*
    Core connection to the database using Entity Framework Core (DB Context)
    For configuration of database settings, entity mappings and other model rules
*/

namespace UrlShortenerAPI.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email).IsUnique();
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });
        }
    }
}