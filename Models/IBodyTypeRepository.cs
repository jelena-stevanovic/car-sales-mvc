using System.Collections.Generic;

namespace CarsSelling.Models
{
    public interface IBodyTypeRepository
    {
        IEnumerable<BodyType> AllBodyTypes { get; }
    }
}
