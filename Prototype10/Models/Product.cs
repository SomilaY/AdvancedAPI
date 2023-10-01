namespace Prototype10.Models
{
    public class Product
    {
        public string? Code { get; set; }
        public string? Name { get; set; }

        public double Price { get; set; }

        public Product(string? code, string? name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }
}
