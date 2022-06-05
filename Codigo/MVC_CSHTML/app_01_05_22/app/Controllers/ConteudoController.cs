using app.Models;
using app.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace app.Controllers
{
    public class ConteudoController : Controller
    {
        //private readonly IComentarioRepositorio _comentarioRepositorio;
        /*public ConteudoController(IComentarioRepositorio comentarioRepositorio)
        {
            _comentarioRepositorio = comentarioRepositorio;
        }*/

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Conteudo()
        {
            return View();
        }

        public IActionResult ConteudoLogado()
        {
            return View();
        }

        /*public IActionResult Perfil()
        {
            List<ComentarioModel> comentario = _comentarioRepositorio.BuscarComentario();
            return View();
        }*/

        /*public IActionResult ConteudoLogado (ComentarioModel comentario)
        {
            _comentarioRepositorio.Comentar(comentario);
            return RedirectToAction("Conteudo");
            return View();
        }*/
    }
}
