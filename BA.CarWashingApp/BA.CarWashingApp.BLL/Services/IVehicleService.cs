using BA.CarWashingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Services
{
    public interface IVehicleService : IService<Vehicle>
    {
     
        bool SearchLicensePlate(string LicensePlate);
        string RegisteringVehicle(Vehicle entity);

        List<Vehicle> GetVehiclewithCustomer();
            
       
    }
}

