using System.Collections.Generic;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Dados.Repositorios
{
    public class PostRepositorio : RepositorioBase<Post>, IPostRepositorio
    {
        public IEnumerable<Post> buscarPorTitulo(string titulo)
        {
            return Db.Postagens.Where(p => p.Titulo == titulo);
        }
    }
}
