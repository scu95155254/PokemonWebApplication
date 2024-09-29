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

        [HttpGet]
        public async Task<IActionResult> GetPokemon()
        {
            var pokemons = await _pokemonService.GetPokemonsAsync();

            return Ok(pokemons);
        }
    }
}