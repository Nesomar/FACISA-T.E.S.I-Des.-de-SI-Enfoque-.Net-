

using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplicacao.Interface
{
    public interface IPostAppService : IServiceAppBase<Post>
    {
        IEnumerable<Post> buscarPorTitulo(string titulo);
    }
}
