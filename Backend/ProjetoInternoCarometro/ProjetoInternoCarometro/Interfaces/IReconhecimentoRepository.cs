using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Interfaces
{
    /// <summary>
    /// Interface resonsável pela ReconhecimentoRepository
    /// </summary>
    interface IReconhecimentoRepository
    {

        bool Verificar(string faceId);

    }
}
