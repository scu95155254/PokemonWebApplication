using PokemonWebApplication.Entities;

namespace PokemonWebApplication.Repositories
{
    public interface IPokemonRepository
    {
        Task<List<Pokemon>> GetPokemonsAsync();
    }
}
