using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Camozzi.Model.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T>,IDisposable
        where T : class
    {
        public readonly CamozziEntities _context;
        protected RepositoryBase()
        {
            _context = CamozziEntities.GetInstance();
        }

        public List<T> GetAll()
        {
                IQueryable<T> query = _context.Set<T>();
                return query.ToList();
        }
        public T FindById(int id)
        {
                return _context.Set<T>().Find(id);

        }
        public virtual T FindByName(string name)
        {
            return _context.Set<T>().Find(name);
        }
        public void Add(T t)
        {
            _context.Set<T>().Add(t);
            _context.SaveChanges();
        }
        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
            _context.SaveChanges();
        }

        public virtual void Update(T t)
        {

        }

        public virtual void UpdateContext()
        {
            CamozziEntities.UpdateInstance();    
        }

        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }
    }
}
