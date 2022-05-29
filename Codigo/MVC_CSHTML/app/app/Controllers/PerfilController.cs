using app.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Perfil()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Editar(string UserName)
        {
            return View();
        }

        public IActionResult Apagar()
        {
            return View();
        }

    }
}
