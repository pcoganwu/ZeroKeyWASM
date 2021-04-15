using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZeroKeyWASM.Server.Models;

namespace ZeroKeyWASM.Server.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IList<Product>> GetAllProducts()
        {
            return await _appDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(Guid productId)
        {
            return await _appDbContext.Products.FirstOrDefaultAsync(p => p.ProductId == productId);
        }
    }
}
