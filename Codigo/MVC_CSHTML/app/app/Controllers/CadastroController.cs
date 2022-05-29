using app.Models;
using app.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace app.Controllers
{
    public class CadastroController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public CadastroController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Perfil()
        {
            List <UsuarioModel> usuario = _usuarioRepositorio.BuscarUsuario();
            return View(usuario);

        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(UsuarioModel cadastro)
        {
            _usuarioRepositorio.Cadastrar(cadastro);
            return RedirectToAction("Perfil");
        }
    }
}
