using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Repositorios
{
    public interface IPostRepositorio : IRepositorioBase<Post>
    {
        IEnumerable<Post> buscarPorTitulo(string titulo);
    }
}
