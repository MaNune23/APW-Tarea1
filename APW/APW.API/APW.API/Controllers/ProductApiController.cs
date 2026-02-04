using APW.Architecture.Repositories;
using APW.Models;
using Microsoft.AspNetCore.Mvc;

namespace APW.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApiController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet(Name = "GetProducts")]
        public IActionResult Get()
        {
            var products = _productRepository.GetAll();
            return Ok(products);
        }
    }
}
