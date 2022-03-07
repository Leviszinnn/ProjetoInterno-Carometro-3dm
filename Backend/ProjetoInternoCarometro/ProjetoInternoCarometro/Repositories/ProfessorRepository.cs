using ProjetoInternoCarometro.Contexts;
using ProjetoInternoCarometro.Domains;
using ProjetoInternoCarometro.Interfaces;
using ProjetoInternoCarometro.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Repositories
{
    public class ProfessorRepository : IProfessorRepository
    {

        private readonly CarometroContext ctx;

        public ProfessorRepository(CarometroContext appContext)
        {
            ctx = appContext;
        }

        public Professor Login(string email, string senha)
        {
            //Encontrando algum usuário que exista através do email
            //var professor = ctx.Professors.FirstOrDefault(p => p.Email == email);
            //if (professor != null)
            //{
            //    bool confere = Criptografia.Comparar(senha, professor.Senha);
            //    if (confere)
            //        return professor;
            //    else
            //    {
            //        if (professor.Senha.Length < 32)
            //        {
            //            var novaSenha = Criptografia.GerarHash(professor.Senha);

            //            professor.Senha = novaSenha;

            //            ctx.Professors.Update(professor);

            //            ctx.SaveChanges();
            //        }
            //    }
                return ctx.Professors.FirstOrDefault(u => u.Email == email && u.Senha == senha);
                //criptorafar caso esteja descriptografado
                //if (professor.Senha.Length < 32)
                //{
                //    var novaSenha = Criptografia.GerarHash(professor.Senha);

                //    professor.Senha = novaSenha;

                //    ctx.Professors.Update(professor);

                //    ctx.SaveChanges();
                //}
                ////Com o usuario encontrado, temos a hash do banco para poder comparar com a senha vinda do formulário


                //bool comparado = Criptografia.Comparar(senha, professor.Senha);
                //if (comparado)
                //{
                //    return professor;
                //}
            }
        }
    }
