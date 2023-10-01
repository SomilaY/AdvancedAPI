using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype10.Data;
using Prototype10.Models;
using System.Linq;

namespace Prototype10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route ("AllProducts")]
        public List<Product> GetProducts() 
        {
            return ProductDB.Products;

         
        }
        [HttpGet]
        [Route ("ByPrice")]
        public List<Product> GetProductPrice(double price) 
        { 
         return ProductDB.Products.Where(p => p.Price < price).ToList();

        }

        [HttpGet]
        [Route ("{Code:Alpha}", Name ="Prd")]

        public Product GetProductByCode(string code)
        {
            return ProductDB.Products.Where(p => p.Code.Equals(code)).FirstOrDefault();

        }
        [HttpPost]
        [Route ("Create")]
        public bool CreateProduct(string code, string desc, double price) 
        {
         Product pr = new Product(code, desc, price);
         ProductDB.Products.Add(pr);
         return true;
        }

        [HttpDelete]
        [Route ("{code:Alpha}", Name ="Delete")]

        public bool DeleteProduct(string code)
        {
            var st = ProductDB.Products.Where(p => p.Code.Equals(code)).FirstOrDefault();
            return ProductDB.Products.Remove(st);
        }

        [HttpPut]
        [Route("{code:Alpha}", Name ="Update")]
        public bool UpdateProduct(string code, string name, double price)
        {
            var st = ProductDB.Products.Where(p => p.Code.Equals(code)).FirstOrDefault();
            if (st != null) 
            {
                st.Name = name;
                st.Price = price;
                return true;

             }
            return false;
        }



    }
}
