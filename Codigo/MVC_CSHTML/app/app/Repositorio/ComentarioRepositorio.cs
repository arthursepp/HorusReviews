using app.Data;
using app.Models;

namespace app.Repositorio
{
    public class ComentarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ComentarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ComentarioModel Comentar(ComentarioModel comentario)
        {
            _bancoContext.Comentario.Add(comentario);
            _bancoContext.SaveChanges();
            return comentario;
        }
    }
}
