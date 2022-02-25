using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoCarometro.Domains
{
    public partial class Escola
    {
        public Escola()
        {
            Alunos = new HashSet<Aluno>();
            Professors = new HashSet<Professor>();
        }

        public int IdEscola { get; set; }
        public string NomeEscola { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Professor> Professors { get; set; }
    }
}
