using Application.Dto.Product;
using Infrastructure.Context;
using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using MediatR;
using Infrastructure.Interfaces;

namespace Application.Features.ProductFeatures.Commands;

public class CreateProductCommand : IRequest<CreateProductCommandResponse>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Barcode { get; set; }
    public int ProductUnitId { get; set; }
    public int ProductCategoryId { get; set; }
}
public class CreateProductCommandResponse
{
    public long Id { get; set; }
}

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductCommandResponse>
{
    private readonly IAppContext _applicationContext;
    public CreateProductCommandHandler(IAppContext applicationContext)
    {
        _applicationContext = applicationContext;
    }
    public async Task<CreateProductCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var p = new Product
        {

            Title = request.Title,
            CreateDate = DateTime.Now,
            Description = request.Description,
            EditeDate = DateTime.Now,
            DateCreateProduct = DateTime.Now,
            ProductCategoryId = request.ProductCategoryId,
            ProductUnitId = request.ProductUnitId,
            QrBarCode = request.Barcode

        };
        await _applicationContext.Products.AddAsync(p);
        await _applicationContext.SaveChangesAsync();


        return new CreateProductCommandResponse { Id = p.Id };
    }
}

