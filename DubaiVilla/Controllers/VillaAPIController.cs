using System;
using DubaiVilla.Data;
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
            return VillaStore.villaList;
        }
    }
}