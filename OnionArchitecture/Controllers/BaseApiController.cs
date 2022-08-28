using Microsoft.AspNetCore.Mvc;
using Application.Features;
using Application.Dto;
using MediatR;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
   // [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    }
}
