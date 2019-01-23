using HouseDJ.Musicas.AcessoDados.Entity.Context;
using HouseDJ.Musicas.Dominio;
using HouseDJ.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseDJ.Musicas.Repositorios.Entity
{
    public class AlbunsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbunsRepositorio(MusicasDbContext contexto)
            :base(contexto)
        {

        }
    }
}
