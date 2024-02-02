using IntegracaoDiagramaDeNos.Models;
using IntegracaoDiagramaDeNos.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntegracaoDiagramaDeNos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeViewModel  _homeViewModel;
        public HomeController(ILogger<HomeController> logger, HomeViewModel homeViewModel)
        {
            _logger = logger;
            _homeViewModel = homeViewModel;
        }

        public IActionResult Index()
        {
            _homeViewModel.teste();
            return View(_homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
