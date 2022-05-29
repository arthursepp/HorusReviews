using app.Models;
using app.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    public class ConteudoController : Controller
    {
        private readonly IComentarioRepositorio _comentarioRepositorio;
        public ConteudoController(IComentarioRepositorio comentarioRepositorio)
        {
            _comentarioRepositorio = comentarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Conteudo()
        {
            return View();
        }

        public IActionResult Conteudo (ComentarioModel comentario)
        {
            _comentarioRepositorio.Comentar(comentario);
            return RedirectToAction("Conteudo");
        }
    }
}
