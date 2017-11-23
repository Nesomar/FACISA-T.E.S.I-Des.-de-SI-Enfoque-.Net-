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
    public class ComentarioAppService : AppServiceBase<Comentario>, IComentarioAppService
    {
        private readonly IComentarioService _comentarioAppService;

        public ComentarioAppService(IComentarioService comentarioAppService) : base(comentarioAppService) => _comentarioAppService = comentarioAppService;
    }
}
