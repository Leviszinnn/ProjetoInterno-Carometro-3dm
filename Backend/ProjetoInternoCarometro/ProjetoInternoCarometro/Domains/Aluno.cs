using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoCarometro.Domains
{
    public partial class Aluno
    {
        public int IdAluno { get; set; }
        public int? IdEscola { get; set; }
        public int? IdSerie { get; set; }
        public int? IdTurma { get; set; }
        public string IdFace { get; set; }
        public string NomeAluno { get; set; }
        public string Cpf { get; set; }
        public string Rm { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Foto { get; set; }

        public virtual Escola IdEscolaNavigation { get; set; }
        public virtual Serie IdSerieNavigation { get; set; }
        public virtual Turma IdTurmaNavigation { get; set; }
    }
}
