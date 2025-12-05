using AutoMapper;
using InventoryManagement.Data.Entities;
using InventoryManagement.Data.Inteface;
using InventoryManagement.Service.DTO;
using InventoryManagement.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Repository
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repo,IMapper mapper)
        {
            _repo=repo;
            _mapper=mapper;
        }

       

        public async Task<CategoryDto> CreateAsync(CategoryCreateDto dto)
        {
            var entity = _mapper.Map<Category>(dto);

            await _repo.AddCategoryAsync(entity);
            await _repo.SaveChangesAsync();

            
            return _mapper.Map<CategoryDto>(entity);
        }

        public async Task<List<CategoryDto>> GetAllAsync()
        {
            var category = await _repo.GetCategories();
            return _mapper.Map<List<CategoryDto>>(category);
        }

       public async Task<CategoryDto?> GetByIdAsync(int id)
        {
            var category = await _repo.GetCategoryByIdAsync(id);

            if (category == null)
                return null;

            return _mapper.Map<CategoryDto>(category);
        }
    }
}
