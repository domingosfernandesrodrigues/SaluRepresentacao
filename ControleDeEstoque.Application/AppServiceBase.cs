using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
//using System.AutoMapper;

namespace ControleDeEstoque.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> ServiceBase)
        {
            _serviceBase = ServiceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        //public IEnumerable<TEntity> ObterTodos(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includes)
        //{
        //    var result = _serviceBase.ObterTodos(
        //        Mapper.Map<Expression<Func<TEntity, bool>>>(expression),
        //        Mapper.Map<Expression<Func<TEntity, object>>[]>(includes));
        //    return Mapper.Map<IEnumerable<TEntity>>(result);
        //}

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
