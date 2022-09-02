using Application.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICreateProductCommand
    {
        Task<long> Create(AddProductDto request);
    }
}
