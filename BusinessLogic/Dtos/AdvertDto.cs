using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Dtos
{
    public class AdvertDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string ContactInformation { get; set; }
        public int Price { get; set; }
        public string Foto { get; set; }
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
    }
}
