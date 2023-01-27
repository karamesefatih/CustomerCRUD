using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.GenericRepositoryDesignPattern
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetAllWithTwoConditions(Expression<Func<T, bool>> filter = null, Expression<Func<T, bool>> filter2 = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
    }
}
