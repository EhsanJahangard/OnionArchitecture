using Application.Dto.Product;
using Application.Features.ProductFeatures.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.v1
{
    // [ApiVersion("1.0")]
    public class ProductController : BaseApiController
    {

        public ProductController()
        {


        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var command = new AddProductDto();
            command.Title = "ali22";
            command.Description = "aliinpr2oduct";
            command.Barcode = "qr11441122";





            return Ok(await Mediator.Send(command));


        }

        //public async Task<long> List()
        //{
        //    var x =  _product.List();
        //    return 1;


        //}
    }
}
