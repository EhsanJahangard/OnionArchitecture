using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.Product
{
    public class AddProductDto : IRequest<long>
    {
        public string Title { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
    }
}
