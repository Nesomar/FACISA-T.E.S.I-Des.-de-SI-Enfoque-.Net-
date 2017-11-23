using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplicacao
{
    public class PostAppService : AppServiceBase<Post>, IPostAppService
    {
        private readonly IPostService _postService;

        public PostAppService(IPostService postAppService) : base(postAppService) => _postService = postAppService;

        public IEnumerable<Post> buscarPorTitulo(string titulo) => _postService.BuscarPorTitulo(titulo);
    }
}
