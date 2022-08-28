using Application.Dto.Product;
using Application.Interfaces.IContext;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProductFeatures.Queries
{
    public class ListProductById 
    {
        private readonly IApplicationContext _context;
        public ListProductById(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<Dto.Product.ListProductDto>> List(long resuly, CancellationToken cancellationToken)
        {
            var x = new List<Dto.Product.ListProductDto> { new Dto.Product.ListProductDto {  Id=1, Barcode="ASd", CreateDate=DateTime.Now,EditeDate=DateTime.Now, Description="asd", Title="asd" } };
            return x;
        }
    }
}
