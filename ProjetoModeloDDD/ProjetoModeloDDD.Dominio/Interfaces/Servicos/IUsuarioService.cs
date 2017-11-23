using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Servicos
{
    public interface IUsuarioService : IServicoBase<Usuario>
    {
        IEnumerable<Usuario> buscarPorNome(string nome);
    }
}
