using Application.Dto.Product;
using Application.Features.ProductFeatures.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductController : BaseApiController
    {
        Application.Interfaces.ICreateProductCommand _addProduct;
        Application.Interfaces.IListProductById _listProduct;
        public ProductController(Application.Interfaces.ICreateProductCommand addProduct, Application.Interfaces.IListProductById listProduct)
        {
            _addProduct = addProduct;
            _listProduct = listProduct;

        }
        [HttpGet]
        public async Task<IActionResult> List(long ProductId)
        {
            var res = await _listProduct.List(ProductId);


            return Ok(res);


        }
        [HttpPost]
        public async Task<IActionResult> Add()
        {
            var res = await _addProduct.Create(new AddProductDto { Barcode = "NewNewNewNeWenwEnwENwENbarcode", Description = "NewNewNewNeWenwEnwENwENbarcode2", Title = "newProductNeeeeeeeeew" });


            return Ok(res.ToString());


        }

    }
}
