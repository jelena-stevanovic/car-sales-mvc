using System.Collections.Generic;

namespace CarsSelling.Models
{
    public class FuelTypeRepository : IFuelTypeRepository
    {
        private readonly AppDbContext _appDbContext;

        public FuelTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<FuelType> AllFuelTypes => _appDbContext.FuelTypes;
    }
}
