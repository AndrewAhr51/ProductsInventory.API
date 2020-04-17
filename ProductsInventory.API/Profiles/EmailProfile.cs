using AutoMapper;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Profiles
{
    public class EmailProfile: Profile
    {
        public EmailProfile()
        {
            CreateMap<Entities.Email, Models.EmailDto>();
            CreateMap<Models.EmailForCreationDto, Entities.Email>();
            CreateMap<Models.EmailForUpdateDto, Entities.Email>();
            CreateMap<Entities.Email, Models.EmailForUpdateDto>();
        }
    }
}
