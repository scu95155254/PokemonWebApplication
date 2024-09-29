using MediatR;
using PokemonWebApplication.Entities;
using PokemonWebApplication.Models.Pokemon;

namespace PokemonWebApplication.Queries
{
    public class GetPokemonsQuery : IRequest<List<Pokemon>>
    {
        public PokemonIndexViewModel ViewModel { get; }

        public GetPokemonsQuery(PokemonIndexViewModel viewModel)
        {
            ViewModel = viewModel;
        }
    }
}