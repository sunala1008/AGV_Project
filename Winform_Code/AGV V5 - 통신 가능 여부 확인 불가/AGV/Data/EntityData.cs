using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AGV.Data
{
    class EntityData<T> where T : class
    {
        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (AGV_ProjectEntities entities = new AGV_ProjectEntities())
            {
                return entities.Set<T>().Select(selector).ToList();
            }
        }

        public List<T> GetAll()
        {
            using (AGV_ProjectEntities entities = new AGV_ProjectEntities())
            {
                return entities.Set<T>().ToList();
            }
        }

        public void Insert(T entity)
        {
            using (AGV_ProjectEntities entities = new AGV_ProjectEntities())
            {
                entities.Set<T>().Add(entity);
                entities.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (AGV_ProjectEntities entities = new AGV_ProjectEntities())
            {
                entities.Entry(entity).State = EntityState.Modified;
                entities.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (AGV_ProjectEntities entities = new AGV_ProjectEntities())
            {
                entities.Entry(entity).State = EntityState.Deleted;
                entities.SaveChanges();
            }
        }

        public int GetCount()
        {
            using (AGV_ProjectEntities entities = new AGV_ProjectEntities())
            {
                return entities.Set<T>().Count();
            }
        }
    }
}
