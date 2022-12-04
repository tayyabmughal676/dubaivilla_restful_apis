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
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public ActionResult<IEnumerable<VillaDTO>> GetVillas()
        {
            return Ok(VillaStore.villaList);
        }


        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(400, Type = typeof(VillaDTO))]
        public ActionResult<VillaDTO?> GetVilla(int id)
        {

            if (id == 0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villaList.FirstOrDefault(u => u.id == id);
            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<VillaDTO> CreateVilla([FromBody] VillaDTO villaDTO)
        {

            if (villaDTO == null)
            {
                return BadRequest(villaDTO);
            }

            if (villaDTO.id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            villaDTO.id = VillaStore.villaList.OrderByDescending(u => u.id).FirstOrDefault().id + 1;
            VillaStore.villaList.Add(villaDTO);

            return Ok(villaDTO);

        }
    }
}