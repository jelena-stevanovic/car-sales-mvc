using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarsSelling.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FuelType>().HasData(new FuelType { Id = 1, Name = "Gasoline" });
            modelBuilder.Entity<FuelType>().HasData(new FuelType { Id = 2, Name = "Diesel" });
            modelBuilder.Entity<FuelType>().HasData(new FuelType { Id = 3, Name = "Bio-diesel" });

            modelBuilder.Entity<Make>().HasData(new Make { Id = 1, Name = "Audi" });
            modelBuilder.Entity<Make>().HasData(new Make { Id = 2, Name = "Citroen" });
            modelBuilder.Entity<Make>().HasData(new Make { Id = 3, Name = "BMW" });
            modelBuilder.Entity<Make>().HasData(new Make { Id = 4, Name = "Dacia" });

            modelBuilder.Entity<BodyType>().HasData(new BodyType { Id = 1, Name = "Hatchback" });
            modelBuilder.Entity<BodyType>().HasData(new BodyType { Id = 2, Name = "Coupe" });
            modelBuilder.Entity<BodyType>().HasData(new BodyType { Id = 3, Name = "Sedan" });
            modelBuilder.Entity<BodyType>().HasData(new BodyType { Id = 4, Name = "SUV" });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = 1,
                MakeId = 1,
                Model = "A4",
                Year = 2022,
                Description = "The standard features of the Audi A4 40 Premium include 2.0L I - 4 201hp intercooled turbo engine, 7 - speed auto - shift manual transmission with overdrive 4 - wheel anti -lock brakes(ABS), side seat mounted airbags, SIDEGUARD curtain 1st and 2nd row overhead airbags, driver and passenger knee airbag, airbag occupancy sensor, automatic air conditioning, and cruise control.",
                FuelTypeId = 2,
                Price = 39100,
                Power = 201,
                Displacement = 2000,
                BodyTypeId = 3,
                Contact = "5069324472",
                ImagePath = "~/ImageUpload/659281fd-f4d4-4a40-a399-7ca60c0e6366.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = 2,
                MakeId = 2,
                Model = "DS5",
                Year = 2011,
                Description = "The size of the DS5 is compact (only 4,53 m), and the trunk volume is 468 liters, with the rear seats folded down to 1.288 liters.",
                FuelTypeId = 1,
                Price = 11450,
                Power = 156,
                Displacement = 1598,
                BodyTypeId = 1,
                Contact = "6046927694",
                ImagePath = "~/ImageUpload/dbf2f3a3-e732-4d58-997e-904c9e5d4fc7.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = 3,
                MakeId = 4,
                Model = "Logan",
                Year = 2013,
                Description = "The Dacia Logan is a more family oriented vehicle. You get a huge load space – up to 1,518 litres with the seats folded flat – which is bigger than most of its mainstream competitors. ",
                FuelTypeId = 2,
                Price = 8360,
                Power = 90,
                Displacement = 1400,
                BodyTypeId = 3,
                Contact = "6147274670",
                ImagePath = "~/ImageUpload/3a20cb03-dade-418c-9f60-787f39ab207c.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = 4,
                MakeId = 3,
                Model = "4",
                Year = 2021,
                Description = "The 2022 BMW 4 Series blends class and performance in a way that few other luxury small cars can.The BMW 4 Series is an upmarket coupe that seats four. ",
                FuelTypeId = 1,
                Price = 39870,
                Power = 228,
                Displacement = 1983,
                BodyTypeId = 2,
                Contact = "3063027591",
                ImagePath = "~/ImageUpload/cd09419e-9509-4719-bcb2-123df35b0640.jpg"
            });

            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = 5,
                MakeId = 1,
                Model = "A3",
                Year = 2016,
                Description = "This small two-door Audi hatch came equipped with a 2.0-liter turbocharged four-cylinder engine, with an optional diesel power plant.",
                FuelTypeId = 2,
                Price = 9995,
                Power = 110,
                Displacement = 1197,
                BodyTypeId = 1,
                Contact = "4038889985",
                ImagePath = "~/ImageUpload/2872ccba-ccc1-401a-870e-a76bff9d9503.jpg"
            });
            modelBuilder.Entity<Car>().HasData(new Car
            {
                Id = 6,
                MakeId = 2,
                Model = "C5",
                Year = 2022,
                Description = "Citroen C5 Aircross is currently available in Diesel engine. The 1997 cc Diesel engine generates a power of 174.33@3750rpm and a torque of 400Nm@2000rpm.",
                FuelTypeId = 2,
                Price = 30000,
                Power = 130,
                Displacement = 1499,
                BodyTypeId = 4,
                Contact = "5062111872",
                ImagePath = "~/ImageUpload/92ebbdc6-5e7b-4d8e-a3e6-9fc6fa143eae.jpg"
            });
        }
    }
}
