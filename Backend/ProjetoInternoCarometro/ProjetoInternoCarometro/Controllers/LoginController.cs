using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using ProjetoInternoCarometro.Domains;
using ProjetoInternoCarometro.Interfaces;
using ProjetoInternoCarometro.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        private readonly IProfessorRepository _professorRepository;

        public LoginController(IProfessorRepository contexto)
        {
            _professorRepository = contexto;
        }

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="login">Objeto login que contém o e-mail e a senha do usuário</param>
        /// <returns>Retorna um token com as informações do usuário</returns>
        /// dominio/api/Login
        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Professor profBuscado = _professorRepository.Login(login.Email, login.Senha);

                if (profBuscado == null)
                {
                    return BadRequest("Email ou senha inválidos!");
                }

                var minhasClaims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, profBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, profBuscado.IdProfessor.ToString()),

                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("carometro-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var meuToken = new JwtSecurityToken(
                        issuer: "ProjetoInternoCarometro",
                        audience: "ProjetoInternoCarometro",
                        claims: minhasClaims,
                        expires: DateTime.Now.AddHours(1),
                        signingCredentials: creds
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(meuToken)
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
