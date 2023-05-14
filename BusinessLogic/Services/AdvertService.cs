using AutoMapper;
using BusinessLogic.Dtos;
using BusinessLogic.Interfaces;
using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class AdvertService : IAdvertService

    {
        private readonly AdvertDbContext context;
        private readonly IMapper mapper;

        public AdvertService(AdvertDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async void Create(AdvertDto advertDto)
        {
            await context.Adverts.AddAsync(mapper.Map<Advert>(advertDto));
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var advertDto = GetById(id);
           context.Adverts.Remove (mapper.Map<Advert>( advertDto));
            context.SaveChanges();
        }

        public void Edit(AdvertDto advertDto)
        {
            context.Adverts.Update(mapper.Map<Advert>(advertDto));
            context.SaveChanges();
        }
        
        public IEnumerable<AdvertDto> GetAll()
        {
            var adverts =  context.Adverts.Include(x=>x.Category).ToList();
            return  mapper.Map<IEnumerable<AdvertDto>> (adverts);
        }
        
        public AdvertDto? GetById(int id)
        {
            if (id < 0) return null; // Bad Request: 400
            var advert = context.Adverts.Find(id);

            if (advert == null) return null;
            return mapper.Map<AdvertDto>(advert);
        }

  
    }
}
