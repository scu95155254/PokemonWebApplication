namespace PokemonWebApplication.Models.Pokemon
{
    public class PokemonIndexViewModel
    {
        private readonly HttpClient _httpClient;

        public string Name { get; set; }
        public string Type { get; set; }
        public string EvolutionStage { get; set; } // 基礎、1階進化、2階進化
        public List<Entities.Pokemon> SearchResults { get; set; } // 查詢結果
    }
}
