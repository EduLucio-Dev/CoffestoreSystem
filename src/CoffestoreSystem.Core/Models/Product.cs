using CoffestoreSystem.Core.Enums;
using System.Reflection.Metadata.Ecma335;

namespace CoffestoreSystem.Core.Models
{
    public class Product : ModelBase
    {
        public string Title { get; set; } = string.Empty;
        public double Price { get; set; }
        public string Description { get; set; }
        public ECoffeType Type { get; set; }
    }
}
