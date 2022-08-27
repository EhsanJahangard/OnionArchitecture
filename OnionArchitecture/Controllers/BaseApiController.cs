using Microsoft.AspNetCore.Mvc;
using Application.Features;
using Application.Dto;
namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
   // [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {

        }
       
    }
}
