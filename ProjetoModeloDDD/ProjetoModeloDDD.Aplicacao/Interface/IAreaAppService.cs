using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplicacao.Interface
{
    public interface IAreaAppService : IServiceAppBase<Area>
    {
        IEnumerable<Area> buscarPorNome(string nome);
    }
}
