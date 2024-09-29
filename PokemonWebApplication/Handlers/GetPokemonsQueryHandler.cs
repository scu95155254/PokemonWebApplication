using MediatR;
using PokemonWebApplication.Entities;
using PokemonWebApplication.Queries;
using PokemonWebApplication.Repositories;

namespace PokemonWebApplication.Handlers
{
    // 處理器類
    public class GetPokemonsQueryHandler : IRequestHandler<GetPokemonsQuery, List<Pokemon>>
    {
        private readonly IPokemonRepository _pokemonRepository; // 假設你有一個 PokemonRepository 用來存取資料

        public GetPokemonsQueryHandler(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }

        public async Task<List<Pokemon>> Handle(GetPokemonsQuery request, CancellationToken cancellationToken)
        {
            // 使用 Repository 獲取所有寶可夢
            var pokemons = await _pokemonRepository.GetPokemonsAsync(); // 這個方法需要在你的 Repository 中實現

            request.ViewModel.SearchResults = pokemons;

            return pokemons;
        }

    }
}
