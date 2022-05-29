using app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<ComentarioModel> Comentario { get; set; }
        public DbSet<ConteudoModel> Conteudo { get; set; }
    }
}
