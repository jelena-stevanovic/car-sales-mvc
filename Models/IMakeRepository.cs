using System.Collections.Generic;

namespace CarsSelling.Models
{
    public interface IMakeRepository
    {
        public IEnumerable<Make> AllMakes { get; }
    }
}
