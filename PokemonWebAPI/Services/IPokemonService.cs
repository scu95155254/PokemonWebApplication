using PokemonWebAPI.Entity;

namespace PokemonWebAPI.Services
{
    public interface IPokemonService
    {
        Task<Pokemon> GetPokemonByIdAsync(int id);
    }
}