using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroKeyWASM.Server.Models;

namespace ZeroKeyWASM.Server.DataAccess
{
    public interface IProductRepository
    {
        Task<IList<Product>> GetAllProducts();
        Task<Product> GetProduct(Guid productId);
    }
}
