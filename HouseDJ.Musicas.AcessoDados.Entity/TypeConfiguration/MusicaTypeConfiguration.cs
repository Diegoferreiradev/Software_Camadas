using HouseDJ.Comum.Entity;
using HouseDJ.Musicas.Dominio;

namespace HouseDJ.Musicas.AcessoDados.Entity.TypeConfiguration
{
    public class MusicaTypeConfiguration : HouseDJEntityAbstractConfig<Musica>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .HasColumnName("MUS_ID")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(P => P.Nome)
                .HasColumnName("MUS_NOME")
                .HasMaxLength(80)
                .IsRequired();

            Property(P => P.IdAlbum)
                .HasColumnName("ALB_ID")
                .IsRequired();
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Album)
                .WithMany(p => p.Musicas)
                .HasForeignKey(fk => fk.IdAlbum);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("MUS_MUSICAS");
        }
    }
}
