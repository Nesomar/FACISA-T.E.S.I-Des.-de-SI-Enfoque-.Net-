using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity BuscarPorID(int ID);
        IEnumerable<TEntity> BuscarTodos();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
