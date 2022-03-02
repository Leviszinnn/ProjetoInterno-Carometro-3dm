using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoCarometro.Domains
{
    public partial class Turma
    {
        public Turma()
        {
            Alunos = new HashSet<Aluno>();
        }

        public int IdTurma { get; set; }
        public string LetraTurma { get; set; }

        public virtual ICollection<Aluno> Alunos { get; set; }
    }
}
