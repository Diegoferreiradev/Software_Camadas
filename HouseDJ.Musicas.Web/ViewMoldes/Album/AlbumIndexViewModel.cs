using System.ComponentModel.DataAnnotations;

namespace HouseDJ.Musicas.Web.ViewMoldes.Album
{
    public class AlbumExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Álbum")]
        public string Nome { get; set; }

        [Display(Name = "Ano do Álbum")]
        public int Ano { get; set; }

        [Display(Name = "Observações")]
        public string Observacoes { get; set; }

        [Display(Name = "E-mail de Contato")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}  