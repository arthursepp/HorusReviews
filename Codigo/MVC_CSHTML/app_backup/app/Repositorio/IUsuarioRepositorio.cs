using app.Data;
using app.Models;
using System.Collections.Generic;

namespace app.Repositorio
{
    public interface IUsuarioRepositorio
    {

        List<UsuarioModel> BuscarUsuario();
        UsuarioModel Cadastrar(UsuarioModel cadastro);
    }
}
