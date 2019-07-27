using DellaViaAutomation.Dal.Abstract.Infrastructure;
using DellaViaAutomation.Entities.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DellaViaAutomation.Bll.Concreate
{
    public class EntityManager<T> : Interfaces.IEntityRepository<T> where T : class
    {
        private IRepository<T> _;
        public EntityManager(IRepository<T> Repository)
        {
            _ = Repository;
        }

        public void Add(T entity)
        {
            _.Add(entity);
        }

        public void Delete(T entity)
        {
            _.Delete(entity);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            _.Delete(where);
        }

        public T Get(Expression<Func<T, bool>> where, params string[] navigations)
        {
            return _.Get(where, navigations);
        }

        public IEnumerable<T> GetAll(params string[] navigations)
        {
            return _.GetAll(navigations);
        }

        public T GetById(long id, params string[] navigations)
        {
            return _.GetById(id, navigations);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where, params string[] navigations)
        {
            return _.GetMany(where, navigations);
        }

        public void Update(T entity)
        {
            _.Update(entity);
        }
    }
}
