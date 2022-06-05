using app.Data;
using app.Models;
using System.Collections.Generic;
using System.Linq;

namespace app.Repositorio
{
    public class ComentarioRepositorio : IComentarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ComentarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ComentarioModel ListarPorComent(string TextoComentario)
        {
            return _bancoContext.Comentario.FirstOrDefault(x => x.TextoComentario == TextoComentario);
        }

        public List<ComentarioModel> BuscarComentario()
        {
            return _bancoContext.Comentario.ToList();
        }

        public ComentarioModel Comentar(ComentarioModel comentario)
        {
            _bancoContext.Comentario.Add(comentario);
            _bancoContext.SaveChanges();
            return comentario;
        }
    }
}
