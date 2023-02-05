using Application.Dto.Product;
using Application.Features.ProductFeatures.Commands;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Features.ProductFeatures.Queries;

namespace Presentation.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductController : BaseApiController
    {
        private readonly IMediator _mediator;
        public ProductController(IMediator mediator)
        {
            _mediator = mediator;

        }
        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommand command)
        {
            var res = await _mediator.Send(command);


            return Ok(res);


        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ListProductQuery query)
        {
            var res = await _mediator.Send(query);


            return Ok(res);


        }


    }
}
