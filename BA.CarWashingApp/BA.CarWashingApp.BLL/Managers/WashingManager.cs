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
    public class WashingManager:BaseManager<Washing>, IWashingService
    {
        public WashingManager(IUow uow) : base(uow)
        {
        }

        public void GetQue(string LicensePlate, string TypeName)
        {
            throw new NotImplementedException();
        }


        public List<Washing> ListProcess()
        {
            var washing = _uow.GetRepository<Washing>();

            var data = washing.GetQueryable().Include(x => x.Employee).Include(x => x.Vehicle).Include(x => x.WashingTypeWashings).ThenInclude(x => x.WashingType).Include(x => x.WashingTypeWashings).ThenInclude(x => x.WashingType).ThenInclude(x => x.WashingSteps).ToList();
            return data;
        }

        public List<Washing> ListVehicleDetail(int washingId)
        {
            var washing = _uow.GetRepository<Washing>();

            var data = washing.GetQueryable().Where(x => x.Id == washingId).Include(x => x.Vehicle).ThenInclude(x=>x.Customer).Include(x=>x.Vehicle).ThenInclude(x=>x.DirtStatus).Include(x => x.Vehicle).ThenInclude(x => x.VehicleType).ToList();
            return data;
        }

        public List<Washing> ListDetail(int washingId)
        {
            var washing = _uow.GetRepository<Washing>();

            var data = washing.GetQueryable().Where(x => x.Id == washingId).Include(x=>x.Employee).Include(x=>x.WashingRecipe).ToList();
            return data;
        }

        public void Washing()
        {
            //status true=>musait
            var musaitCalisan = _uow.GetRepository<Employee>().GetQueryable().FirstOrDefault(x=>x.Status==true);

            if (musaitCalisan != null)
            {
                var siradakiAraba = _uow.GetRepository<Vehicle>().GetQueryable().Where(x=>x.Washing.Status == "Sırada").OrderBy(a => a.OrderNo).FirstOrDefault();

                if (siradakiAraba != null)
                {
                    // yıkama başlıyor
                    var siradakiArabaYikamasi = _uow.GetRepository<Washing>().GetQueryable().Where(x => x.Vehicle.Id == siradakiAraba.Id && x.Status =="Sırada").FirstOrDefault();
                    var yikamaSuresi = siradakiArabaYikamasi.RemainingTime;
                    var yikamaBaslangicZamani = DateTime.Now;
                    var yikamaBitisZamani = yikamaBaslangicZamani.AddMinutes(yikamaSuresi);

                    // Araba yıkamasının(true =>yıkamada, çalışanı status(false=>meşgul) güncelledim(ADIM UNUTMA)!!!!!!!!!!!
                    siradakiArabaYikamasi.Status = "Yıkamada";
                    musaitCalisan.Status = false;
                    _uow.GetRepository<Washing>().Update(siradakiArabaYikamasi);
                    _uow.GetRepository<Employee>().Update(musaitCalisan);
                    _uow.SaveChanges();

                    // Yıkama tamamlandığında araba yikamasını ve çalışanı güncelledim
                    siradakiArabaYikamasi.Status = "Bitti";
                    musaitCalisan.Status = true;
                    _uow.GetRepository<Washing>().Update(siradakiArabaYikamasi);
                    _uow.GetRepository<Employee>().Update(musaitCalisan);
                    _uow.SaveChanges();

                    // Araba sırasından sıradaki arabayı çıkarmak GEREKLİ Mİ GERİ DÖN!!!!!!!!!
                    //
                    // Yıkamanın bitişine kadar sonraki arabayı bekletme
                    Task.Delay((int)(yikamaBitisZamani - DateTime.Now).TotalMinutes).Wait();
                }
            }
        }

    }
}
