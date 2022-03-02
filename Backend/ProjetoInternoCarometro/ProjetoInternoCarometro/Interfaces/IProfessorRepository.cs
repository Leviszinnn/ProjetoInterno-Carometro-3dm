using ProjetoInternoCarometro.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Interfaces
{
    /// <summary>
    /// Interface resonsável pelo ProfessorRepository
    /// </summary>
    public interface IProfessorRepository
    {

        /// <summary>
        /// Valida um usuario
        /// </summary>
        /// <param name="email">email do usuario</param>
        /// <param name="senha">senha do usuario</param>
        /// <returns>Objeto Usuario que foi encontrado</returns>
        Professor Login(string email, string senha);
    }
}
