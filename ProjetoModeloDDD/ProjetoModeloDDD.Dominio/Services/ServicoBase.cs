using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using ProjetoModeloDDD.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Services
{
    public class ServicoBase<TEntity> : IDisposable, IServicoBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorioBase;

        public ServicoBase(IRepositorioBase<TEntity> repositorio) => _repositorioBase = repositorio;
        public void Adicionar(TEntity obj)
        {
            _repositorioBase.Adicionar(obj);
        } 

        public void Atualizar(TEntity obj)
        {
            _repositorioBase.Atualizar(obj);
        }

        public TEntity BuscarPorID(int ID)
        {
            return _repositorioBase.BuscarPorID(ID);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return _repositorioBase.BuscarTodos();
        }

        public void Dispose()
        {
            _repositorioBase.Dispose();
        }

        public void Remover(TEntity obj)
        {
            _repositorioBase.Remover(obj);
        }
    }
}
