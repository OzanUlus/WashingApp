using BA.CarWashingApp.DAL.Abstract;
using BA.CarWashingApp.DAL.Context;
using BA.CarWashingApp.Entity.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.DAL.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
           return _context.Set<T>().Where(x => x.Id == id).FirstOrDefault();
        }

        public IQueryable<T> GetQueryable()
        {
            return _context.Set<T>().AsQueryable<T>();
        }

        public void Update(T entity)
        {
            var oldDAta = _context.Set<T>().Find(entity.Id);
            oldDAta = entity;
        }
    }
}
