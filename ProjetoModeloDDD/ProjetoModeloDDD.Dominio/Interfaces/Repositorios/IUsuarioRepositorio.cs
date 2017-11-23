using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Repositorios
{
    public interface IUsuarioRepositorio : IRepositorioBase<Usuario>
    {
        IEnumerable<Usuario> buscarPorNome(string nome);
    }
}
