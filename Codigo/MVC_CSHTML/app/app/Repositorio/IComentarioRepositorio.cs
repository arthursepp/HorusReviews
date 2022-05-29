using app.Models;

namespace app.Repositorio
{
    public interface IComentarioRepositorio
    {
        ComentarioModel Comentar(ComentarioModel comentario);
    }
}
