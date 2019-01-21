using HouseDJ.Musicas.AcessoDados.Entity.TypeConfiguration;
using HouseDJ.Musicas.Dominio;
using System.Data.Entity;

namespace HouseDJ.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
        }
    }
}
