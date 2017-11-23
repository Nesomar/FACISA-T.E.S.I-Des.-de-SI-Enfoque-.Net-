

using System.Collections.Generic;
using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;

namespace ProjetoModeloDDD.Aplicacao
{
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService) : base(usuarioService) => _usuarioService = usuarioService;

        public IEnumerable<Usuario> buscarPorNome(string nome) => _usuarioService.buscarPorNome(nome);
    }
}
