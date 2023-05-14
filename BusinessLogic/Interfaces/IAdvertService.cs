using BusinessLogic.Dtos;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IAdvertService
    {
         IEnumerable<AdvertDto> GetAll();
        AdvertDto? GetById(int id);
        void Create(AdvertDto advertDto);
        void Edit(AdvertDto advertDto);
        void Delete(int id);
    }
}
