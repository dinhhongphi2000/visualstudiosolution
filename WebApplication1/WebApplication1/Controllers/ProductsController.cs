using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product {ID = 1,Name ="Tomato soup",Category="Groceries",Price=1 },
            new Product {ID =2,Name="Yo-yo",Category="Toys",Price=3.75M },
            new Product {ID =2,Name="Hammer",Category="Hardware",Price=16.99M }
        };

        public IEnumerable<Product> GetAllProduct()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault(p => p.ID == id);
            if(product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
