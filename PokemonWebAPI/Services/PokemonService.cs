using PokemonWebAPI.Entities;
using PokemonWebAPI.Repositories;

namespace PokemonWebAPI.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly IPokemonRepository _pokemonRepository;

        public PokemonService(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }   

        public Task<List<Pokemon>> GetPokemonsAsync()
        {
            return _pokemonRepository.GetPokemonsAsync();
        }
    }
}