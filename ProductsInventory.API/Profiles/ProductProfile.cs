using AutoMapper;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.Products, Models.ProductDto>();
            CreateMap<Models.ProductForCreationDto, Entities.Products>();
            CreateMap<Models.ProductForUpdateDto, Entities.Products>();
            CreateMap<Entities.Products, Models.ProductForUpdateDto>();
        }
    }
}
