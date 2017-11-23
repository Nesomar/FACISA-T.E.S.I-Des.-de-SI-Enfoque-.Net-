using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Servicos
{
    public interface IAreaService : IServicoBase<Area>
    {
        IEnumerable<Area> buscarPorNome(string nome);
    }
}
