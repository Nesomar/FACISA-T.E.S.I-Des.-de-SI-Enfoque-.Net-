using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.Dominio.Entidades;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplicacao
{
    public class AreaAppService : AppServiceBase<Area>, IAreaAppService
    {
        private readonly IAreaService _areaAppService;

        public AreaAppService(IAreaService areaAppService) : base(areaAppService) => _areaAppService = areaAppService;

        public IEnumerable<Area> buscarPorNome(string nome) => _areaAppService.buscarPorNome(nome);
    }
}
