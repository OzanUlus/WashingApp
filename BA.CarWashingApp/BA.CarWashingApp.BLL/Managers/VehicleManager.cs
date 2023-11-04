using BA.CarWashingApp.BLL.Services;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Managers
{
    public class VehicleManager : BaseManager<Vehicle>, IVehicleService
    {
        public VehicleManager(IUow uow) : base(uow)
        {
        }

        
        
            //UI da  araç kaydet sayfasında customer add de çağır.
        

       

        public string RegisteringVehicle(Vehicle entity)
        {
            var repo = _uow.GetRepository<Vehicle>();
            var isExist = SearchLicensePlate(entity.LicensePlate);
            if (isExist)
            {
                
                return "plaka zaten tanımlı";
            }
            repo.Add(entity);
            _uow.SaveChanges();
            return "araç başırı ile eklendi";

            
        }

   

        public bool SearchLicensePlate(string LicensePlate)
        {
            
        
                var plateno = _uow.GetRepository<Vehicle>().GetAll().Where(x => x.LicensePlate == LicensePlate).FirstOrDefault();
                if (plateno != null)
                {
                    return true;
                }
                return false;


           
            
          
            
            
            
        }

      
    }
}
