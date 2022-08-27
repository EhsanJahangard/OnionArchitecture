using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.v1
{
   // [ApiVersion("1.0")]
    public class ProductController : BaseApiController
    {
        Application.Interfaces.IProduct _product;
        public ProductController(Application.Interfaces.IProduct product)
        {
            _product = product;

        }
        public async Task<long> List()
        {
            var x =  _product.List();
            return 1;
        
        
        }
    }
}
