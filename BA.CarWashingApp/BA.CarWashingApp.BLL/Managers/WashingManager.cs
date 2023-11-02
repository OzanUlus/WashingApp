using BA.CarWashingApp.BLL.Services;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Managers
{
    public class WashingManager : BaseManager<Washing>, IWashingService
    {
        public WashingManager(IUow uow) : base(uow)
        {
        }

        

        public List<Washing> EmployeeDetail(int id)
        {   
            var data = _uow.GetRepository<Washing>().GetQueryable().Include(x => x.Employee.Id==id).Include(x=>x.Vehicle).ToList();
            return data;    
        }

        

    

        

    
    }
}
