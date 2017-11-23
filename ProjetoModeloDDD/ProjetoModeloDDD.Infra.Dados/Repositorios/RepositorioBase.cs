using ProjetoModeloDDD.Dominio.Interfaces.Repositorios;
using ProjetoModeloDDD.Infra.Dados.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Dados.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositorioBase<TEntity> where TEntity : class
    {
        protected ContextoAplicacao Db = new ContextoAplicacao();
        public void Adicionar(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Atualizar(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public TEntity BuscarPorID(int ID)
        {
            return Db.Set<TEntity>().Find(ID);
        }

        public IEnumerable<TEntity> BuscarTodos()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }
      
    }
}
