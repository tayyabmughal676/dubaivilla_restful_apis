using System;
using DubaiVilla.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace DubaiVilla.Controllers
{
    [Route("Api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO{id=1, Name="Pool View"},
                new VillaDTO{id=1, Name="Pool View"},
            };
        }



    }
}

