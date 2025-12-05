using InventoryManagement.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }
      
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var productlist = await _service.GetAllAsync();

            return Ok(productlist);
        }
    }
}
