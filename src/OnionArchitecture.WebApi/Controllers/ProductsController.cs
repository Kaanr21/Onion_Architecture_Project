using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.WebApi.Abstractions;

namespace OnionArchitecture.WebApi.Controllers
{


    public class ProductsController : BaseApiController
    {
        [HttpPost]
        public IActionResult GetProducts()
        {

            var products = new List<object>
            {
                new { Id = 1, Name = "Laptop", Price = 1500.00 },
                new { Id = 2, Name = "Smartphone", Price = 800.00 },
                new { Id = 3, Name = "Tablet", Price = 400.00 }
            };

            return Ok(products);

        }

        [HttpGet]
        public IActionResult GetProducts2()
        {

            var products = new List<object>
            {
                new { Id = 1, Name = "Laptop", Price = 1500.00 },
                new { Id = 2, Name = "Smartphone", Price = 800.00 },
                new { Id = 3, Name = "Tablet", Price = 400.00 }
            };

            return BadRequest("bir hata oldu");

        }
    }
}
