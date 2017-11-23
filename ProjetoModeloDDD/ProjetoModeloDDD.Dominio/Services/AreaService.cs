

using System.Collections.Generic;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;
using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class AreaService : ServicoBase<Area>, IAreaService
    {
        private readonly IAreaRepositorio _areaRepositorio;
        public AreaService(IAreaRepositorio areaRepositorio) : base(areaRepositorio) => _areaRepositorio = areaRepositorio;
        public IEnumerable<Area> buscarPorNome(string nome) => _areaRepositorio.buscarPorNome(nome);
    }
}
