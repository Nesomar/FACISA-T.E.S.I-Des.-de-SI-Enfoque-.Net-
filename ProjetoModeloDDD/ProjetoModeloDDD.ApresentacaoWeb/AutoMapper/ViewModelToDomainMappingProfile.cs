using AutoMapper;
using ProjetoModeloDDD.ApresentacaoWeb.ViewModels;
using ProjetoModeloDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.ApresentacaoWeb.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName

        {
            get { return "ViewModelToDomainMappings"; }

        }
        protected override void Configure()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<PostViewModel, Post>();
            Mapper.CreateMap<ComentarioViewModel, Comentario>();
            Mapper.CreateMap<AreaViewModel, Area>();
        }
    }
}