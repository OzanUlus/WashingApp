using BA.CarWashingApp.BLL.Services;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Managers
{
    public class BaseManager<T>:IService<T> where T : class,IEntity
    {
        protected IUow _uow;
        public BaseManager(IUow uow)
        {
            _uow = uow;
        }
        public void Add(T entity)
        {
            _uow.GetRepository<T>().Add(entity);
            _uow.SaveChanges();
        }
        public void Delete(T entity) 
        {
            _uow.GetRepository<T>().Delete(entity);
            _uow.SaveChanges();
        } 
        public T GetById(int id) => _uow.GetRepository<T>().GetById(id);
        public List<T> GetAll() => _uow.GetRepository<T>().GetAll();
        public void Update(T entity) 
        { 
            _uow.GetRepository<T>().Update(entity);
            _uow.SaveChanges();
        } 

        public IQueryable<T> GetQueryable() => _uow.GetRepository<T>().GetQueryable();
    }
}
