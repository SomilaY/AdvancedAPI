using Prototype10.Models;

namespace Prototype10.Data
   
{
    public static class ProductDB
    {
        public static List<Product> Products { get; set; } = new List<Product>()
        {   new Product("P123", "Butter", 25.79),
             new Product("P124", "Eggs", 30),
             new Product("P125", "Bacon", 43) };
        }

    }

