﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace HouseDJ.Musicas.Web.ViewMoldes.Musica
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