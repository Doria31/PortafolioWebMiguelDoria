using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using PortafolioWeb.Models;
using System.Diagnostics;

namespace PortafolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var proyectos=ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }
            
        public IActionResult Privacy()
        {
            return View();
        }

        private List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto> {

                new Proyecto

                {
                    Titulo= "App para certificaciones Microsoft",
                    Descripcion= "Portal de entretemiento Tecnologias Microsoft",
                    link = "https://learn.microsoft.com/es-es/certifications/",
                    ImagenURL= "/images/microsoft.png",
                },

                new Proyecto

                {
                    Titulo= "Grupo Bancolombia",
                    Descripcion= "Desarrollo App para clientes",
                    link = "https://www.bancolombia.com/personas//",
                    ImagenURL= "/images/bancol.png",
                },

                new Proyecto

                {
                    Titulo= "Desarrollo App virtual exito",
                    Descripcion= "Desarrollo App compras online angular",
                    link = "https://www.exito.com//",
                    ImagenURL= "/images/exito.jpg",
                },

                new Proyecto

                {
                    Titulo= "Desarrollo App Simulador de prestamos",
                    Descripcion= "Desarrollo App de Prestamos",
                    link = "https://www.bancoldex.com/",
                    ImagenURL= "/images/fotoperfil.jpg",
                },


            };
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
