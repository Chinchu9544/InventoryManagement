using InventoryManagement.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{

        //    var categorylist = await _service.GetAllAsync();

        //    return Ok(categorylist);
        //}
    }
}
