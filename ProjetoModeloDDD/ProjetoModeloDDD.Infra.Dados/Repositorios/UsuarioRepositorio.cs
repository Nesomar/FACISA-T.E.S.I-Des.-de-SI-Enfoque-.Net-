using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Dados.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public IEnumerable<Usuario> buscarPorNome(string nome)
        {
            return Db.Usuarios.Where(u => u.Nome == nome);
        }
    }
}
