using System.Collections.Generic;

namespace ProjetoModeloDDD.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<TEntity> where TEntity : class
    {
        void Adicionar(TEntity obj);
        TEntity BuscarPorID(int ID);
        IEnumerable<TEntity> BuscarTodos();
        void Atualizar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
