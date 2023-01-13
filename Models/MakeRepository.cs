using System.Collections.Generic;

namespace CarsSelling.Models
{
    public class MakeRepository : IMakeRepository
    {
        private readonly AppDbContext _appDbContext;

        public MakeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Make> AllMakes => _appDbContext.Makes;
    }
}
