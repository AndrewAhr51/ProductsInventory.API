using AutoMapper;
using ProductsInventory.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsInventory.API.Profiles
{
    public class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Entities.Tag, Models.TagDto>();
            CreateMap<Models.TagForCreationDto, Entities.Tag>();
            CreateMap<Models.TagForUpdateDto, Entities.Tag>();
            CreateMap<Entities.Tag, Models.TagForUpdateDto>();
        }
      
    }
}
