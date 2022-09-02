using Application.Dto.Product;
using Application.Features.ProductFeatures.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductController : BaseApiController
    {

        public ProductController()
        {


        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            
        
            
            return Ok("List");


        }
        [HttpPost]
        public  async Task<IActionResult> Add()
        {
            var x = new Application.Features.ProductFeatures.Commands.CreateProductCommand();


            return Ok("Add");


        }

    }
}
