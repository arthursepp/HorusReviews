using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class UsuarioModel
    {
        [Key]
        public string UserName { get; set; }
        [NotNull]
        public string Nome { get; set; }
        [NotNull]
        public System.DateTime DataNasc { get; set; }
        [NotNull]
        public string Email { get; set; }
        [NotNull]
        public string Senha { get; set; }
    }
}
