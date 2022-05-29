using app.Data;
using app.Models;
using System.Collections.Generic;
using System.Linq;

namespace app.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public UsuarioModel ListarPorUName(string UserName)
        {
            return _bancoContext.Usuario.FirstOrDefault(x => x.UserName == UserName);
        }

        public List<UsuarioModel> BuscarUsuario()
        {
            return _bancoContext.Usuario.ToList();
        }

        public UsuarioModel Cadastrar(UsuarioModel cadastro)
        {
            _bancoContext.Usuario.Add(cadastro);
            _bancoContext.SaveChanges();
            return cadastro;
        }


    }
}
