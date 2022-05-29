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

        public IActionResult Editar()
        {
            return View();
        }
    }
}
