using AutoMapper;
using HouseDJ.Musicas.Dominio;
using HouseDJ.Musicas.Web.ViewMoldes.Album;

namespace HouseDJ.Musicas.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumIndexViewModel>();
        }
    }
}