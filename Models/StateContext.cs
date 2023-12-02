using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class StateContext : DbContext
    {
        public StateContext(DbContextOptions<StateContext> options)
            : base(options) { }


        public DbSet<State> States { get; set; }
        public DbSet<Direction> Directions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Direction>().HasData(
                new Direction { DirectionId = "No", Name= "North"},
                new Direction { DirectionId = "Ne", Name = "NorthEast" },
                new Direction { DirectionId = "Ea", Name = "East" },
                new Direction { DirectionId = "Se", Name = "SouthEast" },
                new Direction { DirectionId = "So", Name = "South" },
                new Direction { DirectionId = "Sw", Name = "SouthWest" },
                new Direction { DirectionId = "We", Name = "West" },
                new Direction { DirectionId = "Nw", Name = "NorthWest" }
                );

            modelBuilder.Entity<State>().HasData(
                    new State
                    {
                        StateId = 1,
                        Name = "South Dakota",
                        Description = "Description",
                        DirectionId = "No"

                    },
                     new State
                     {
                         StateId = 2,
                         Name = "Minnesota",
                         Description = "Description",
                          DirectionId = "No"
                     }



                );
        }
    }
}
