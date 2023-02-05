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
using Microsoft.EntityFrameworkCore;

namespace Application.Features.ProductFeatures.Queries
{
    public class ListProductQuery : IRequest<List<ListProductQueryResponse>>
    {
        //For Search
        public string TitleProduct { get; set; }
    }


    public class ListProductQueryResponse
    {
        public string Title { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }

    }
    public class ListProductQueryHandler : IRequestHandler<ListProductQuery, List<ListProductQueryResponse>>
    {
        private readonly IApplicationContext _applicationContext;
        public ListProductQueryHandler(IApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public async Task<List<ListProductQueryResponse>> Handle(ListProductQuery request, CancellationToken cancellationToken)
        {

            var result = await _applicationContext
                                .Products
                                .AsNoTracking()
                                .Select(f => new ListProductQueryResponse
                                {
                                    Barcode = f.QrBarCode,
                                    Description = f.Description,
                                    Title = f.Title
                                }).ToListAsync();

            return result;
        }
    }

   


}
