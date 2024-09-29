using PokemonWebAPI.Entities;

namespace PokemonWebAPI.Repositories
{
    public interface IPokemonRepository
    {
        Task<List<Pokemon>> GetPokemonsAsync();
    }
}
