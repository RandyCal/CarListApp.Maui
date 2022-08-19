using Microsoft.EntityFrameworkCore;

namespace CarListApp.Api
{
    public class CarListDbContext : DbContext
    {
        public CarListDbContext(DbContextOptions<CarListDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>().HasData(
                
                new Car
                {
                    Id = 1,
                    Make = "Chevorlet",
                    Model = "Camaro",
                    Vin = "144"
                },

                new Car
                {
                    Id = 2,
                    Make = "Honda",
                    Model = "Civic",
                    Vin = "186"
                },

                 new Car
                 {
                     Id = 3,
                     Make = "Dodge",
                     Model = "Challenger",
                     Vin = "123"
                 },
                 
                 new Car
                 {
                     Id = 4,
                     Make = "Nissan",
                     Model = "Altima",
                     Vin = "225"
                 }, 
                 
                 new Car
                 {
                     Id = 5,
                     Make = "Ford",
                     Model = "Shelby Cobra GT",
                     Vin = "234"
                 },
                 
                 new Car
                 {
                     Id = 6,
                     Make = "Toyota",
                     Model = "Celica",
                     Vin = "297"
                 },
                 
                 new Car
                 {
                     Id = 7,
                     Make = "Lambhorgini",
                     Model = "Spyder",
                     Vin = "305"
                 }

                );
        }

    }
}