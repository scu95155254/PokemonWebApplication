namespace PokemonWebApplication.Models.Pokemon
{
    public class PokemonIndexViewModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string EvolutionStage { get; set; } // 基礎、1階進化、2階進化

        public List<Pokemon> SearchResults { get; set; } // 查詢結果
    }

    public class Pokemon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Ability { get; set; }
        public string EvolutionStage { get; set; }
        public string area { get; set; }
    }
}
