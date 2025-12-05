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
    public  class CategoryRepository :ICategoryRepository
    {
        private readonly InventoryDbContext _context;
        public CategoryRepository(InventoryDbContext context) {
        
          _context=context;
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<List<Category>> GetCategories()
        {
            var categorylist = await _context.Categories.ToListAsync();
            return categorylist;
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.SingleOrDefaultAsync(c=>c.Id==id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
