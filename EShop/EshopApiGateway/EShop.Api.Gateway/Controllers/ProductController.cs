using Eshop.Infrastructure.Commands.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShop.Api.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] CreateProduct product)
        {
            await Task.CompletedTask;
            return Accepted("Product Created");
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromForm] CreateProduct product)
        {
            await Task.CompletedTask;
            return Accepted("Get Method Called");
        }
    }
}
