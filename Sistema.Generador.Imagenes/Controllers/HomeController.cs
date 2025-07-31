using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sistema.Generador.Imagenes.Models;

namespace Sistema.Generador.Imagenes.Controllers
{
    /// <summary>
    /// Controlador principal de la aplicación. Provee las vistas de inicio,
    /// privacidad y maneja la página de error.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Muestra la página principal.
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Muestra la página de política de privacidad.
        /// </summary>
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        /// <summary>
        /// Muestra la página de error con información de la solicitud.
        /// </summary>
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
