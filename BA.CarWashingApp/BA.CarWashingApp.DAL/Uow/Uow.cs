using BA.CarWashingApp.DAL.Abstract;
using BA.CarWashingApp.DAL.Context;
using BA.CarWashingApp.DAL.Repository;
using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.DAL.Uow
{
    public class Uow:IUow
    {
        AppDbContext _context;

        public Uow(AppDbContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }


        public IRepository<T> GetRepository<T>() where T :class, IEntity
        {
            return new GenericRepository<T>(_context);
        }

    }
}
