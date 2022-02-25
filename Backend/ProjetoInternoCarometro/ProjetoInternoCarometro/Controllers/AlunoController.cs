using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInternoCarometro.Domains;
using ProjetoInternoCarometro.Interfaces;
using ProjetoInternoCarometro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private IAlunoRepository _alunoRepository { get; set; }

        public AlunoController()
        {
            _alunoRepository = new AlunoRepository();
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(Aluno aluno)
        {
            try
            {
                _alunoRepository.cadastrarAluno(aluno);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
