using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HouseDJ.Musicas.Web.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        [Required(ErrorMessage = "O E-mail é obrigatório!")]
        [MaxLength(30, ErrorMessage = "O E-mail não pode ter mais de 30 Caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória!")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}