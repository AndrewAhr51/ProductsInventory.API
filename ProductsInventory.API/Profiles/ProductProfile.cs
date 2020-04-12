using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Entities
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
