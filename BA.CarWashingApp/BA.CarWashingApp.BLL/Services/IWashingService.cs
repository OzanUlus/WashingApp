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
        void GetQue(string LicensePlate, string TypeName);
        void Washing(string TypeName, string StatusName, string Name, string UseName );
        void ListProcess();

    }
}
