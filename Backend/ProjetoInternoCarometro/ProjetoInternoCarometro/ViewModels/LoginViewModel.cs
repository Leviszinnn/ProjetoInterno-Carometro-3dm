using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoInternoCarometro.ViewModels
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Informe seu e-mail!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe sua senha!")]
        public string Senha { get; set; }
    }
}
