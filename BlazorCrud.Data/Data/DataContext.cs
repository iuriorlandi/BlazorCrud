using BlazorCrud.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("games");
                entity.HasKey(g => g.Id);
                entity.Property(g => g.Id).HasColumnName("id");
                entity.Property(g => g.Name).HasColumnName("name");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
