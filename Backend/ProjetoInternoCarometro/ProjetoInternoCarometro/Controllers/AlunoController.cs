using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoInternoCarometro.Domains;
using ProjetoInternoCarometro.Interfaces;
using ProjetoInternoCarometro.Repositories;
using ProjetoInternoCarometro.Utils;
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
        public IActionResult Cadastrar([FromForm] Aluno novoAluno, IFormFile arquivo)
        {
            try
            {
                _alunoRepository.Cadastrar(novoAluno);

                string[] extensoesPermitidas = { "jpg", "png", "jpeg", "gif" };
                string uploadResultado = Upload.UploadFile(arquivo, extensoesPermitidas);

                if (uploadResultado == "")
                {
                    return BadRequest("Arquivo não encontrado!");
                }

                if (uploadResultado == "Extensão não permitida!")
                {
                    return BadRequest("Extensão de arquivo não permitida!");
                }

                novoAluno.Foto = uploadResultado;

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


        [HttpGet]
        public IActionResult ListarTodos()
        {
            try
            {
                return Ok(_alunoRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [HttpDelete("{idAluno}")]
        public IActionResult Deletar(int idAluno)
        {
            try
            {

                var alunoBuscado = _alunoRepository.BuscarId(idAluno);
                if (alunoBuscado == null)
                {
                    return NotFound();
                }

                _alunoRepository.Deletar(alunoBuscado);


                //Removendo Arquivo do servidor
               Upload.RemoverArquivo(alunoBuscado.Foto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



        [HttpPost("imagem")]
        public IActionResult PostarDir([FromForm] Aluno aluno, IFormFile arquivo)
        {
            try
            {
                string[] extensoesPermitidas = { "jpg", "png", "jpeg", "gif" };
                string uploadResultado = Upload.UploadFile(arquivo, extensoesPermitidas);

                if (uploadResultado == "")
                {
                    return BadRequest("Arquivo não encontrado!");
                }

                if (uploadResultado == "Extensão não permitida!")
                {
                    return BadRequest("Extensão de arquivo não permitida!");
                }

                aluno.Foto = uploadResultado;

                return Ok();
            }
            catch (Exception erro)
            {

                return BadRequest(erro.Message);
            }
        }


    }
}
