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
            
        
            
            return Ok();


        }
        [HttpPost]
        public async Task<long> Add()
        {

          

            return 1;


        }

    }
}
