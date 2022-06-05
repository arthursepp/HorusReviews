using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace app.Models
{
    public class ComentarioModel
    {
        [Key]
        public string UserNameComent { get; set; }

        [NotNull]
        public int CodComent { get; set; }

        [NotNull]
        public System.DateTime DataPost { get; set; }

        [NotNull]
        public string TextoComentario { get; set; }

    }
}
