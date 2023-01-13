using System.Collections.Generic;

namespace CarsSelling.Models
{
    public interface IFuelTypeRepository
    {
        IEnumerable<FuelType> AllFuelTypes { get; }
    }
}
