using System.Collections.Generic;

namespace CarsSelling.Models
{
    public class BodyTypeRepository : IBodyTypeRepository
    {
        private readonly AppDbContext _appDbContext;

        public BodyTypeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<BodyType> AllBodyTypes => _appDbContext.BodyTypes;
    }
}
