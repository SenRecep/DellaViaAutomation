﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DellaViaAutomation.Dal.ComplexType;
namespace DellaViaAutomation.Dal.Concreate.EntityFramework
{
    using ComplexType.EntityFramework;
    using DellaViaAutomation.Dal.Abstract.Infrastructure;
    using DellaViaAutomation.Entities.ComplexType;
    using System.Data.Entity;
    using System.Linq.Expressions;

    public abstract class RepositoryBase<T> where T : EntityBase
    {

        #region Properties

        private readonly DbSet<T> dbSet;

        #endregion

        protected RepositoryBase()
        {
            dbSet = DataController.getDb().Set<T>();

        }
        #region Implementation

        public virtual void Add(T entity)

        {
            dbSet.Add(entity);

        }

        public virtual void Update(T entity)

        {
            T dbentity = dbSet.FirstOrDefault(x=>x.id==entity.id);
            ClassDataTransfer.EntityTransmitter(entity,dbentity);
        }

        public virtual void Delete(T entity)

        {
            dbSet.Remove(entity);

        }

        public virtual void Delete(Expression<Func<T, bool>> where)

        {

            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();



            foreach (T obj in objects)

                dbSet.Remove(obj);

        }

        public bool Exists(T entity)
        {
            bool exists = false;

            foreach (T item in dbSet)
            {
                exists = item.Exists(entity, item);
                if (exists==true)
                    break;
            }
            return exists;
        }

        public virtual T GetById(long id, params string[] navigations)

        {

            var set = dbSet.AsQueryable();

            foreach (string nav in navigations)

                set = set.Include(nav);

            return set.FirstOrDefault(f => f.id == id);

        }

        public virtual ICollection<T> GetAll(params string[] navigations)

        {

            var set = dbSet.AsQueryable();

            foreach (string nav in navigations)

                set = set.Include(nav);

            return set.AsEnumerable().ToList();

        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where, params string[] navigations)

        {

            var set = dbSet.AsQueryable();

            foreach (string nav in navigations)

                set = set.Include(nav);

            return set.Where(where).AsEnumerable();

        }

        public T Get(Expression<Func<T, bool>> where, params string[] navigations)

        {

            var set = dbSet.AsQueryable();

            foreach (string nav in navigations)

                set = set.Include(nav);

            return set.Where(where).FirstOrDefault<T>();

        }

        #endregion

    }
}
