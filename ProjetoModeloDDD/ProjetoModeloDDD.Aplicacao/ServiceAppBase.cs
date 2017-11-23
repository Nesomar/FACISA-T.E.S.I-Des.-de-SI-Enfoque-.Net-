

using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Aplicacao
{
    public class AppServiceBase<TEntity> : IDisposable, IServiceAppBase<TEntity> where TEntity : class
    {
        private readonly IServicoBase<TEntity> _serviceAppBase;

        public AppServiceBase(IServicoBase<TEntity> serviceAppBase) => _serviceAppBase = serviceAppBase;

        public void Adicionar(TEntity obj)
        {
            _serviceAppBase.Adicionar(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _serviceAppBase.Atualizar(obj);
        }

        public TEntity BuscarPorID(int ID)
        {
            return _serviceAppBase.BuscarPorID(ID);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
           return _serviceAppBase.BuscarTodos();
        }

        public void Dispose()
        {
            _serviceAppBase.Dispose();
        }

        public void Remover(TEntity obj)
        {
            _serviceAppBase.Remover(obj);
        }
    }
}
