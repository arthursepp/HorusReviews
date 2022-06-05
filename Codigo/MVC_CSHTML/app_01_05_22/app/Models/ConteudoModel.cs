using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ConteudoModel
    {
        [Key]
        public int ContCod { get; set; }

        [NotNull]
        public string ContNome { get; set; }

        [NotNull]
        public string Diretor { get; set; }

        [NotNull]
        public System.DateTime DataLanc { get; set; }

        [NotNull]
        public string Sinopse { get; set; }

        [NotNull]
        public string Categoria { get; set; }
    }
}
