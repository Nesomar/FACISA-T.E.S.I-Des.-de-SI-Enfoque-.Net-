using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Repositorios
{
    public interface IAreaRepositorio : IRepositorioBase<Area>
    {
        IEnumerable<Area> buscarPorNome(string nome);
    }
}
