

using System.Collections.Generic;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class PostService : ServicoBase<Post>, IPostService
    {
        private readonly IPostRepositorio _postRepositorio;
        public PostService(IPostRepositorio postRepositorio) : base(postRepositorio) => _postRepositorio = postRepositorio;
        public IEnumerable<Post> BuscarPorTitulo(string titulo) => _postRepositorio.buscarPorTitulo(titulo);
    }
}
