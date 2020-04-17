using AutoMapper;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<Entities.Address, Models.AddressDto>();
            CreateMap<Models.AddressForCreationDto, Entities.Address>();
            CreateMap<Models.AddressForUpdateDto, Entities.Address>();
            CreateMap<Entities.Address, Models.AddressForUpdateDto>();
        }
    }
       
}
