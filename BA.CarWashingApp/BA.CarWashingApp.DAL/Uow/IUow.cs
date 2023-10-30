using BA.CarWashingApp.DAL.Abstract;
using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.DAL.Uow
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T :class, IEntity;
        void SaveChanges();
    }
}
