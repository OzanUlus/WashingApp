using BA.CarWashingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Services
{
    public interface IWashingService : IService<Washing>
    {
        
        
        List<Washing> EmployeeDetail(int id);

    }
}
