using System.Collections.Generic;
using ProjetoModeloDDD.Dominio.Entidades;
using System.Linq;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;

namespace ProjetoModeloDDD.Infra.Dados.Repositorios
{
    public class AreaRepositorio : RepositorioBase<Area>, IAreaRepositorio
    {
        public IEnumerable<Area> buscarPorNome(string nome)
        {
            return Db.Areas.Where(a => a.Nome == nome);
        }
    }
}
