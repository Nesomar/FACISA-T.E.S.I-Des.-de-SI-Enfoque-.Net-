

using AutoMapper;
using ProjetoModeloDDD.ApresentacaoWeb.ViewModels;
using ProjetoModeloDDD.Dominio.Entidades;

namespace ProjetoModeloDDD.ApresentacaoWeb.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName

        {
            get { return "DomainToViewModelMappings"; }

        }
        protected override void Configure()
        {
            Mapper.CreateMap<Usuario, UsuarioViewModel>();
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<Comentario, ComentarioViewModel>();
            Mapper.CreateMap<Area, AreaViewModel>();
        }
    }
}