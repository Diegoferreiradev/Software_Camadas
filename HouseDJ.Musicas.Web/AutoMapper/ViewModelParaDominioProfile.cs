using AutoMapper;
using HouseDJ.Musicas.Dominio;
using HouseDJ.Musicas.Web.ViewModels.Album;
using HouseDJ.Musicas.Web.ViewModels.Musica;


namespace HouseDJ.Musicas.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlbumViewModel, Album>();
            Mapper.CreateMap<MusicaViewModel, Musica>();
        }
    }
}