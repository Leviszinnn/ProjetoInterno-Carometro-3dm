using ProjetoInternoCarometro.Contexts;
using ProjetoInternoCarometro.Domains;
using ProjetoInternoCarometro.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        CarometroContext ctx = new CarometroContext();

        public void cadastrarAluno(Aluno aluno)
        {
            ctx.Alunos.Add(aluno);
            ctx.SaveChanges();
        }
    }
}
