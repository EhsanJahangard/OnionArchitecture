using Application.Dto.Product;
using Infrastructure.Context;
using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Application.Features.ProductFeatures.Commands
{
    public class CreateProductCommand : ICreateProductCommand
    {
        private IApplicationContext _context;
        public CreateProductCommand(IApplicationContext context)
        {
            _context = context;
        }
        public async Task<long> Create(AddProductDto request)
        {
            var product = new Product();
            product.QrBarCode = request.Barcode;
            product.Title = request.Title;
            product.DateCreateProduct = DateTime.Now;
            product.CreateDate = DateTime.Now;
            product.EditeDate = DateTime.Now;
            product.Description = request.Description;
            product.ProductCategoryId = 1;
            product.ProductUnitId = 2;
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }
    }
}
