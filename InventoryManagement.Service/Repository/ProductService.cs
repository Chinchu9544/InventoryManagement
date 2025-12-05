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
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IProductRepository repo,IMapper mapper) { 
            
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _repo.GetProducts();
            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
