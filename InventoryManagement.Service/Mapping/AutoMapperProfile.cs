using AutoMapper;
using InventoryManagement.Data.Entities;
using InventoryManagement.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Service.Mapping
{
    public  class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryCreateDto, Category>();
        }
        
    }
}
