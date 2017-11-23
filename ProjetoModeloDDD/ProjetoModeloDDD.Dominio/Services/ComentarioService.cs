

using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class ComentarioService : ServicoBase<Comentario>, IComentarioService
    {
        private readonly IComentarioRepositorio _comentarioRepositorio;
        public ComentarioService(IComentarioRepositorio comentarioRepositorio) : base(comentarioRepositorio) => _comentarioRepositorio = comentarioRepositorio;
    }
}
