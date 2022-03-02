using System;
using System.Collections.Generic;

#nullable disable

namespace ProjetoInternoCarometro.Domains
{
    public partial class Professor
    {
        public int IdProfessor { get; set; }
        public int? IdEscola { get; set; }
        public string NomeProfessor { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public virtual Escola IdEscolaNavigation { get; set; }
    }
}
