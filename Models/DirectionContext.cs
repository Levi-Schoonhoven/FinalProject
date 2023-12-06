using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class DirectionContext : DbContext
    {
        public DirectionContext(DbContextOptions<DirectionContext> options) 
                : base(options){ }
        DbSet<Direction> Directions { get; set;}
        DbSet<Direction> Filter { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Direction>().HasData(
                new Direction { DirectionId = "No", Name = "North" }
                );
            modelBuilder.Entity<Filter>().HasData(
                new Filter { DirectionID = "So", DirectionName = "South" }
                );
        }


    }
}
