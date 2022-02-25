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
        private IAlunoRepository _alunoRepository;

        public AlunoController()
        {
            _alunoRepository = new AlunoRepository();
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar(Aluno novoAluno)
        {
            try
            {
                _alunoRepository.Cadastrar(novoAluno);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Aluno alunoAtualizado)
        {
            try
            {
                _alunoRepository.Atualizar(id, alunoAtualizado);
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
