using InventoryManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data.Inteface
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetProducts();
    }
}
