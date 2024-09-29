using MediatR;
using Microsoft.AspNetCore.Mvc;
using PokemonWebApplication.Models.Pokemon;
using PokemonWebApplication.Queries;

namespace PokemonWebApplication.Controllers.Pokemon
{
    public class PokemonController : Controller
    {
        private readonly IMediator _mediator;

        public PokemonController(IMediator mediator)
        {
            _mediator = mediator; // 注入 MediatR 的 IMediator
        }

        public async Task<IActionResult> Index()
        {
            var viewModel = new PokemonIndexViewModel();

            // 創建查詢物件
            var query = new GetPokemonsQuery(viewModel); // 如果有參數，可以在這裡設置

            var pokemons = await _mediator.Send(query); // 使用 MediatR 發送查詢
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(PokemonIndexViewModel model)
        {

            return View(model);
        }
    }
}
