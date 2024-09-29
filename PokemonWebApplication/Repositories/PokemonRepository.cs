using MediatR;
using PokemonWebApplication.Entities;

namespace PokemonWebApplication.Repositories
{
    // 查詢類
    public class PokemonRepository:IPokemonRepository 
    {
        private readonly HttpClient _httpClient;

        public PokemonRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Pokemon>> GetPokemonsAsync()
        {
            // 設定 API 的 URL，這裡假設 API 的端點是 "/api/pokemons"
            var response = await _httpClient.GetAsync(API.GetPokemon());

            var pokemons = new List<Pokemon>();
            // 確認回應成功
            if (response.IsSuccessStatusCode)
            {
                // 反序列化 JSON 成 List<Pokemon>
                pokemons = await response.Content.ReadFromJsonAsync<List<Pokemon>>();
            }

            return pokemons;
        }
    }
}
