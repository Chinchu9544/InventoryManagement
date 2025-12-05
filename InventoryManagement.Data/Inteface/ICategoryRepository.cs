using InventoryManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data.Inteface
{
    public interface ICategoryRepository
    {
        public Task<List<Category>> GetCategories();
        public Task AddCategoryAsync(Category category);
        public Task<Category> GetCategoryByIdAsync(int id);
        Task SaveChangesAsync();
    }
}
