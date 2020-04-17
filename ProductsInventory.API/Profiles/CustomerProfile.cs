using AutoMapper;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Entities.Customer, Models.CustomerDto>();
            CreateMap<Models.CustomerForCreationDto, Entities.Customer>();
            CreateMap<Models.CustomerForUpdateDto, Entities.Customer>();
            CreateMap<Entities.Customer, Models.CustomerForUpdateDto>();
        }
    }
}
