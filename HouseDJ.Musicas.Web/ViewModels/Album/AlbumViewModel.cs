using HouseDJ.Musicas.Web.Annotations;
using System.ComponentModel.DataAnnotations;

namespace HouseDJ.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage = "O ID do álbum é obrigatório!")]
        public int Id { get; set; }

        [Display(Name = "Nome do Álbum")]
        [Required]
        [MaxLength(100, ErrorMessage = "O Nome do álbum poderá ter no máximo 100 caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Ano do Álbum")]
        [Required(ErrorMessage = "O Ano do álbum é obrigatório")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        [MaxLength(100, ErrorMessage = "Você excedeu a quantidade de caracteres para a Obervação que é no máxino 1000")]
        public string Observacoes { get; set; }

        [Display(Name = "E-mail de Contato")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O E-mail não pode ter mais que 50 caracteres")]
        [MaxLength(50)]
        [EmailHouseDj(ErrorMessage = "O E-mail tem que ser da HouseDj")]
        public string Email { get; set; }
    }
}