

using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplicacao.Interface
{
    public interface IUsuarioAppService : IServiceAppBase<Usuario>
    {
        IEnumerable<Usuario> buscarPorNome(string nome);
    }
}
