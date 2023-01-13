using System.Collections.Generic;

namespace CarsSelling.Models
{
    public interface ICarRepository
    {
        IEnumerable<Car> AllCars { get; }
        Car GetCarById(int carId);
        void AddCar(Car car);
        void DeleteCar(int carId);
    }
}
