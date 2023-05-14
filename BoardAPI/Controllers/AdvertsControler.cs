using BusinessLogic.Interfaces;
using Data;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using BusinessLogic.Dtos;

namespace BoardAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertsControler : ControllerBase
    { 

        private readonly IAdvertService advertService;  
         

        public AdvertsControler(IAdvertService advertService)
        {
          this.advertService = advertService;   
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(advertService.GetAll());
        }

        // Details
        [HttpGet("details/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(advertService.GetById(id));
        }

        [HttpPost]
        public IActionResult Create(AdvertDto advertDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            advertService.Create(advertDto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Edit(AdvertDto advertDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            advertService.Edit(advertDto);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            advertService.Delete(id);
            return Ok();
        }


    }
}
