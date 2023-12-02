using Microsoft.EntityFrameworkCore;

namespace FinalProject.Models
{
    public class StateContext : DbContext
    {
        public StateContext(DbContextOptions<StateContext> options)
            : base(options) { }


        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>().HasData(
                    new State
                    {
                        StateId = 1,
                        Name = "South Dakota",
                        Description = "Description"
                    },
                     new State
                     {
                         StateId = 1,
                         Name = "Minnesota",
                         Description = "Description"
                     }



                );
        }
    }
}
