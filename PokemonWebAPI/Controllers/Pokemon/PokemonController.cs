using Microsoft.AspNetCore.Mvc;
using PokemonWebAPI.Services;

namespace PokemonWebAPI.Controllers.Pokemon
{
    [ApiController]
    [Route("api/[controller]")]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;

        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPokemon(int id)
        {
            var pokemon = await _pokemonService.GetPokemonByIdAsync(id);
            if (pokemon == null)
                return NotFound();

            return Ok(pokemon);
        }

    }
}
