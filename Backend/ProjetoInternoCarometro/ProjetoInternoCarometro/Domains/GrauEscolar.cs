using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoCarometro.Domains
{
    public partial class GrauEscolar
    {
        public GrauEscolar()
        {
            Series = new HashSet<Serie>();
        }

        public int IdGrau { get; set; }
        public string NomeGrau { get; set; }

        public virtual ICollection<Serie> Series { get; set; }
    }
}
