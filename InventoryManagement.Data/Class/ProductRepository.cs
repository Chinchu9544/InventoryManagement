using InventoryManagement.Data.Context;
using InventoryManagement.Data.Entities;
using InventoryManagement.Data.Inteface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data.Class
{
    public class ProductRepository : IProductRepository
    {
        private readonly InventoryDbContext _context;

        public ProductRepository(InventoryDbContext context)
        {
            _context=context;
        }
        public async Task<List<Product>> GetProducts()
        {
            var productList = await _context.Products
                                           .Include(p => p.Category).ToListAsync();
            return productList;
        }
    }
}
