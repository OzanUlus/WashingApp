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
        void Washing();

        //genel bilgileri listeleme
        List<Washing> ListProcess();
        //araç bilgileri detay listeleme
        List<Washing> ListVehicleDetail(int washingId);
        //ek bilgiler listeleme
        List<Washing> ListDetail(int washingId);

    }
}
