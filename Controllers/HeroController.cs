using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VerticalDi.Handlers;

namespace VerticalDI.Controllers
{
    [ApiController]
    [Route("api/heroes")]
    public class HeroController : ControllerBase
    {
        private readonly GetHeroHandler _getHeroHandler;

        public HeroController(GetHeroHandler getHeroHandler)
        {
            _getHeroHandler = getHeroHandler;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<string>> GetHero(int id)
        {
            var hero = await _getHeroHandler.GetHeroById(id);
            if (hero == null)
            {
                return NotFound();
            }
            return Ok(hero);
        }
    }
}