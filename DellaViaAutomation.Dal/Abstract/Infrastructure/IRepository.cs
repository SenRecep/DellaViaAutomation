using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Dal.Abstract.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(Expression<Func<T, bool>> where);

        T GetById(long id, params string[] navigations);

        T Get(Expression<Func<T, bool>> where, params string[] navigations);
        bool Exists(T entity);

        ICollection<T> GetAll(params string[] navigations);

        IEnumerable<T> GetMany(Expression<Func<T, bool>> where, params string[] navigations);

    }
}
