using Microsoft.AspNetCore.Http;
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

        public void Atualizar(int idAluno, Aluno alunoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Aluno novoAluno)
        {
            ctx.Alunos.Add(novoAluno);
            ctx.SaveChanges();
        }

        public string ConsultarPerfilDir(int idAluno)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idAluno)
        {
            throw new NotImplementedException();
        }

        public List<Aluno> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public string SalvarPerfilDir(IFormFile foto, int idAluno)
        {
            throw new NotImplementedException();
        }
    }
}
