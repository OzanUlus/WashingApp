using BA.CarWashingApp.BLL.Services;
using BA.CarWashingApp.DAL.Uow;
using BA.CarWashingApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BA.CarWashingApp.BLL.Managers
{
    public class WashingManager : BaseManager<Washing>, IWashingService
    {
        public WashingManager(IUow uow) : base(uow)
        {
        }


        public List<Washing> EmployeeDetail(int id)
        {
            var data = _uow.GetRepository<Washing>().GetQueryable().Include(x => x.Employee).Where(x=>x.Employee.Id==id).Include(x => x.Vehicle).ToList();
            return data;
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

            var data = washing.GetQueryable().Where(x => x.Id == washingId).Include(x => x.Vehicle).ThenInclude(x => x.Customer).Include(x => x.Vehicle).ThenInclude(x => x.DirtStatus).Include(x => x.Vehicle).ThenInclude(x => x.VehicleType).ToList();
            return data;
        }

        public List<Washing> ListDetail(int washingId)
        {
            var washing = _uow.GetRepository<Washing>();

            var data = washing.GetQueryable().Where(x => x.Id == washingId).Include(x => x.Employee).Include(x => x.WashingRecipe).ToList();
            return data;
        }

        public void Washing()
        {
            //status true=>musait
            var musaitCalisan = _uow.GetRepository<Employee>().GetQueryable().FirstOrDefault(x => x.Status == true);

            if (musaitCalisan != null)
            {
                var siradakiAraba = _uow.GetRepository<Vehicle>().GetQueryable().Include(x => x.Washing).Where(x => x.Washing.Status == "sırada").OrderBy(a => a.OrderNo).FirstOrDefault();

                if (siradakiAraba != null)
                {

                    // yıkama başlıyor
                    var siradakiArabaYikamasi = _uow.GetRepository<Washing>().GetQueryable().Where(x => x.Vehicle.Id == siradakiAraba.Id && x.Status == "sırada").FirstOrDefault();
                    var yikamaSuresi = siradakiArabaYikamasi.RemainingTime;
                    var yikamaBaslangicZamani = DateTime.Now;
                    var yikamaBitisZamani = yikamaBaslangicZamani.AddMinutes(yikamaSuresi);
                    ReduceStock(siradakiArabaYikamasi);
                    // Araba yıkamasının(true =>yıkamada, çalışanı status(false=>meşgul) güncelledim
                    siradakiArabaYikamasi.Status = "yıkama başladı";
                    musaitCalisan.Status = false;
                    _uow.GetRepository<Employee>().Update(musaitCalisan);
                    _uow.SaveChanges();

                    //yıkama statüsü her bir adıma göre değişiyor
                    WashingStepProcess(siradakiArabaYikamasi);




                    // Yıkama tamamlandığında araba yikamasını ve çalışanı güncelledim
                    if (yikamaBitisZamani == DateTime.Now)
                    {
                        siradakiArabaYikamasi.Status = "Bitti";
                        musaitCalisan.Status = true;
                        _uow.GetRepository<Washing>().Update(siradakiArabaYikamasi);
                        _uow.GetRepository<Employee>().Update(musaitCalisan);
                        _uow.SaveChanges();
                    }

                    // Yıkamanın bitişine kadar sonraki arabayı bekletme
                    Task.Delay((int)(yikamaBitisZamani - DateTime.Now).TotalMinutes).Wait();
                }
            }
        }
        public void WashingStepProcess(Washing washing)
        {
            //istenilen yıkamaya ait adımları çektim.
            //var steps = _uow.GetRepository<WashingStep>().GetQueryable().Include(x => x.WashingType).ThenInclude(x => x.WashingTypeWashings).ThenInclude(x => x.Washing).Where(x=>x.WashingType.WashingTypeWashings.) .Select(x => new { x.StepName, x.StepTime }).ToList();
            var query = _uow.GetRepository<Washing>().GetQueryable().Where(x => x.Id == washing.Id).Include(x => x.WashingTypeWashings)
               .ThenInclude(x => x.WashingType).ThenInclude(x => x.WashingSteps).FirstOrDefault();
            if (query != null)
            {
                var steps = query.WashingTypeWashings.SelectMany(x => x.WashingType.WashingSteps).ToList();
                foreach (var step in steps)
                {
                    // Yıkama adımlarını işleme soktum.
                    var stepTime = step.StepTime;
                    var stepName = step.StepName;
                    washing.Status = stepName + "'da";
                    _uow.GetRepository<Washing>().Update(washing);
                    _uow.SaveChanges();
                    Task.Delay(stepTime).Wait();

                    // Yıkamanın statusu sürekli güncelle


                }


            }


        }

        public void ReduceStock(Washing washing)
        {
            var data = _uow.GetRepository<Washing>().GetQueryable().Where(x => x.Id == washing.Id)
                .Include(x => x.WashingRecipe).ThenInclude(x => x.MaterialWashingRecipes)
                .ThenInclude(x => x.Material).FirstOrDefault();
            if (data != null)
            {
                var amount = data.WashingRecipe.Amount;
                var stock = data.WashingRecipe.MaterialWashingRecipes.Select(x => x.Material.Stock)
                    .FirstOrDefault();
                if (stock >= amount)
                {
                    stock -= amount;
                }
               
                var m = data.WashingRecipe.MaterialWashingRecipes.Select(x => x.MaterialId).FirstOrDefault();
                var material = _uow.GetRepository<Material>().GetById(m);

                material.Stock = stock;
                _uow.GetRepository<Material>().Update(material);
                _uow.SaveChanges();

            }

        }
    }
}
