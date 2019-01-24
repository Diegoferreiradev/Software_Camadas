using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HouseDJ.Musicas.Web.ViewModels.Musica
{
    public class MusicaExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome da Música")]
        public string Nome { get; set; }

        [Display(Name = "Nome do Álbum")]
        public string NomeAlbum { get; set; }
    }
}