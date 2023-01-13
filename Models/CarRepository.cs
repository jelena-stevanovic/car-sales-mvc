using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CarsSelling.Models
{
    public class CarRepository : ICarRepository
    {
        private readonly AppDbContext _appDbContext;

        public CarRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Car> AllCars => _appDbContext.Cars
            .Include(c => c.Make)
            .Include(c => c.FuelType)
            .Include(c => c.BodyType);

        public Car GetCarById(int carId)
        {
            return _appDbContext.Cars
              .Include(c => c.Make)
              .Include(c => c.FuelType)
              .Include(c => c.BodyType)
              .FirstOrDefault(c => c.Id == carId);
        }

        public void AddCar(Car car)
        {
            _appDbContext.Cars.Add(car);
            _appDbContext.SaveChanges();
        }

        public void DeleteCar(int carId)
        {
            var car = _appDbContext.Cars
               .Include(c => c.Make)
               .Include(c => c.FuelType)
               .Include(c => c.BodyType)
               .FirstOrDefault(c => c.Id == carId);
            _appDbContext.Remove(car);
            _appDbContext.SaveChanges();
        }
    }
}
