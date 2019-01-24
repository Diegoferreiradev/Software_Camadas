using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HouseDJ.Musicas.Web.ViewModels.Musica
{
    public class MusicaViewModel
    {
        [Required(ErrorMessage = "O ID é obrigatório!")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome da Música é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome da música pode ter no máximo 50 caracteres")]
        [Display(Name = "Nome da Música")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione um Álbum válido")]
        [Display(Name = "Álbum")]
        public int IdAlbum { get; set; }
    }
}