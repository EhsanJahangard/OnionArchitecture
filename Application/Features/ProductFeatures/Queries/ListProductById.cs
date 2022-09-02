using Application.Dto.Product;
using Infrastructure.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Features.ProductFeatures.Queries
{
    public class ListProductById : IListProductById
    {
        private IApplicationContext _context;
        public ListProductById(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<List<Dto.Product.ListProductDto>> List(long id)
        {
            var result = _context.Products.Select(x => new ListProductDto
            {
                Barcode = x.QrBarCode,
                CreateDate = x.CreateDate,
                Description = x.Description,
                Id = x.Id,
                Title = x.Title,
                EditeDate = x.EditeDate

            }).ToList();
            return result;
        }
    }

    
}
