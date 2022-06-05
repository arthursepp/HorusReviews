using app.Models;
using System.Collections.Generic;

namespace app.Repositorio
{
    public interface IComentarioRepositorio
    {
        ComentarioModel ListarPorComent(string TextoComentario);
        List<ComentarioModel> BuscarComentario();
        ComentarioModel Comentar(ComentarioModel comentario);
    }
}
