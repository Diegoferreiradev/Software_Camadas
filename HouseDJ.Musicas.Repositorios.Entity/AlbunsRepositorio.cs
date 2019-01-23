using HouseDJ.Musicas.AcessoDados.Entity.Context;
using HouseDJ.Musicas.Dominio;
using HouseDJ.Repositorios.Comum.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HouseDJ.Musicas.Repositorios.Entity
{
    public class AlbunsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbunsRepositorio(MusicasDbContext contexto)
            :base(contexto)
        {

        }

        public override List<Album> Selecionar()
        {
            return _contexto.Set<Album>().Include(a => a.Musicas).ToList();
        }

        public override Album SelecionarPorId(int id)
        {
            return _contexto.Set<Album>().Include(a => a.Musicas).SingleOrDefault(a => a.Id == id);
        }
    }
}
