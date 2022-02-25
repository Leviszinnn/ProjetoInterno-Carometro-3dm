using ProjetoInternoCarometro.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Interfaces
{
    interface IAlunoRepository
    {
        void cadastrarAluno(Aluno aluno);
    }
}
