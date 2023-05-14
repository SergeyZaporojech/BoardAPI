using BusinessLogic.Dtos;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Profiles
{
    internal class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Advert, AdvertDto>()
                    .ForMember(x => x.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            // ProductDto -> Product
            CreateMap<AdvertDto, Advert>()
                .ForMember(x => x.Category, opt => opt.Ignore());
        }
    }
}
