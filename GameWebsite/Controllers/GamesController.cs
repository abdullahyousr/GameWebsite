using GameWebsite.Services;

namespace GameWebsite.Controllers
{
    public class GamesController : Controller
    {
        private readonly ICategoriesService _categoriesService;
        private readonly IDevicesService _devicesService;
        private readonly IGamesService _gamesService;

        public GamesController(ICategoriesService categoriesService, 
            IDevicesService devicesService, 
            IGamesService gamesService)

        {
            _categoriesService = categoriesService;
            _devicesService = devicesService;
            _gamesService = gamesService;
        }

        // Page
        public IActionResult Index()
        {
            var games = _gamesService.GetAll();
            return View(games);
        }

        // Page
        public IActionResult Details(int id) 
        {
            var game = _gamesService.GetById(id);

            if(game is null)
                return NotFound();

            return View(game);
        }

        // Page
        [HttpGet]
        public IActionResult Create()
        {
            var categories = _categoriesService.GetSelectList();
            var devices = _devicesService.GetSelectList();
            CreateGameFormViewModel viewModel = new()
            {
                Categories = categories,
                Devices = devices
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                model.Categories = _categoriesService.GetSelectList();
                model.Devices = _devicesService.GetSelectList();

                return View(model);
            }

            await _gamesService.Create(model);

            return RedirectToAction(nameof(Index));
        }

        // Page
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var game = _gamesService.GetById(id);

            if (game is null)
                return NotFound();

            EditGameFormViewModel viewModel = new()
            {
                Id = game.Id,
                Name = game.Name,
                Description = game.Description,
                CategoryId = game.CategoryId,
                Categories = _categoriesService.GetSelectList(),
                Devices = _devicesService.GetSelectList(),
                SelectedDevices = game.Devices.Select(d => d.DeviceId).ToList(),
                CurrentCover = game.cover
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditGameFormViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _categoriesService.GetSelectList();
                model.Devices = _devicesService.GetSelectList();

                return View(model);
            }

            var game = await _gamesService.Update(model);
            if (game is null)
                return BadRequest();

            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var isDeleted = _gamesService.Delete(id);

            
            return isDeleted ?  Ok() : BadRequest();
        }
    }
}
