using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ploomtopia.Models;
using Ploomtopia.Repositories;

namespace Ploomtopia.Controllers
{
    [ApiController]
    [Route("api/ploomies")]
    public class PloomieController : ControllerBase
    {
        private readonly IPloomieRepository _ploomieRepository;

        public PloomieController(IPloomieRepository ploomieRepository)
        {
            _ploomieRepository = ploomieRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Ploomie[]>> GetAllPloomies()
        {

            var ploomies = await _ploomieRepository.GetAllPloomiesAsync();
            return Ok(ploomies);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ploomie>> GetPloomieById(int id)
        {
            var ploomie = await _ploomieRepository.GetPloomieByIdAsync(id);
            if (ploomie == null)
            {
                return NotFound();
            }
            return Ok(ploomie);
        }

        [HttpPost]
        public async Task<ActionResult<Ploomie>> CreatePloomie(Ploomie ploomie)
        {
            var createdPloomie = await _ploomieRepository.CreatePloomieAsync(ploomie);
            return CreatedAtAction(nameof(GetPloomieById), new { id = createdPloomie.Id }, createdPloomie);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdatePloomie(int id, Ploomie ploomie)
        {
            if (id != ploomie.Id)
            {
                return BadRequest();
            }

            await _ploomieRepository.UpdatePloomieAsync(id, ploomie);

            return Ok(new { message = "Ploomie atualizado com sucesso" });
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePloomie(int id)
        {
            var ploomie = await _ploomieRepository.GetPloomieByIdAsync(id);
            if (ploomie == null)
            {
                return NotFound();
            }

            await _ploomieRepository.DeletePloomieAsync(id);

            return Ok(new { message = "Ploomie removido com sucesso" });
        }
    }
}
