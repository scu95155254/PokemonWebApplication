using Microsoft.AspNetCore.Mvc;
using PokemonWebApplication.Models.Pokemon;

namespace PokemonWebApplication.Controllers.Pokemon
{
    public class PokemonController : Controller
    {
        // 模擬寶可夢資料庫 (實際情況中你可能會查詢資料庫)
        private static List<Models.Pokemon.Pokemon> pokemons = new List<Models.Pokemon.Pokemon>
        {
        new Models.Pokemon.Pokemon { Name = "Pikachu", Type = "Electric", EvolutionStage = "基礎" },
        new Models.Pokemon.Pokemon { Name = "Charizard", Type = "Fire", EvolutionStage = "2階進化" },
        new Models.Pokemon.Pokemon { Name = "Bulbasaur", Type = "Grass", EvolutionStage = "基礎" },
        // 加入更多寶可夢資料...
    };

        public IActionResult Index()
        {
            var viewModel = new PokemonIndexViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(PokemonIndexViewModel model)
        {
            // 查詢邏輯
            var results = pokemons.Where(p =>
                (string.IsNullOrEmpty(model.Name) || p.Name.Contains(model.Name)) &&
                (string.IsNullOrEmpty(model.Type) || p.Type.Contains(model.Type)) &&
                (string.IsNullOrEmpty(model.EvolutionStage) || p.EvolutionStage == model.EvolutionStage)
            ).ToList();

            model.SearchResults = results;
            return View(model);
        }
    }
}
