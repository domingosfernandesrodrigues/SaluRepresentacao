using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        //TEntity Obter(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
        IEnumerable<TEntity> GetAll();
        //IEnumerable<TEntity> GetTodos(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
