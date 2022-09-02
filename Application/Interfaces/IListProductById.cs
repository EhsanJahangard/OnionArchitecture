using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IListProductById
    {
        Task<List<Dto.Product.ListProductDto>> List(long id);
    }
}
