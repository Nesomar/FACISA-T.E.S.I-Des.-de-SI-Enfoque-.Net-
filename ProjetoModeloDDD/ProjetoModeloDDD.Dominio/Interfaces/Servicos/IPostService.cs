using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Servicos
{
    public interface IPostService : IServicoBase<Post>
    {
        IEnumerable<Post> BuscarPorTitulo(string titulo);
    }
}
