using app.Data;
using app.Models;
using System.Collections.Generic;

namespace app.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorUName(string UserName);
        List<UsuarioModel> BuscarUsuario();
        UsuarioModel Cadastrar(UsuarioModel cadastro);
    }
}
