using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Capa.Services.Repositorio
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
        T Get(int id);
        T Get(string id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T Single(Expression<Func<T, bool>> predicate);
        void Attach(T _entity);
    }
}
