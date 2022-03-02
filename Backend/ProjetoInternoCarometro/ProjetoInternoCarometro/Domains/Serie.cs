using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoCarometro.Domains
{
    public partial class Serie
    {
        public Serie()
        {
            Alunos = new HashSet<Aluno>();
        }

        public int IdSerie { get; set; }
        public int? IdGrau { get; set; }
        public string NumeroSerie { get; set; }

        public virtual GrauEscolar IdGrauNavigation { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
