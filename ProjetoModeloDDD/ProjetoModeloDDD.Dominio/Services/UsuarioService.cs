using System.Collections.Generic;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class UsuarioService : ServicoBase<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioService(IUsuarioRepositorio usuarioRepositorio) : base(usuarioRepositorio) => _usuarioRepositorio = usuarioRepositorio;
        public IEnumerable<Usuario> buscarPorNome(string nome) => _usuarioRepositorio.buscarPorNome(nome);
    }
}
