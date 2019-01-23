using System.ComponentModel.DataAnnotations;

namespace HouseDJ.Musicas.Web.ViewMoldes.Musica
{
    public class MusicaViewModel
    {
        [Required(ErrorMessage = "O ID é Obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O Nome da Música deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Selecione um Álbum válido")]
        public int IdAlbum { get; set; }
    }
}