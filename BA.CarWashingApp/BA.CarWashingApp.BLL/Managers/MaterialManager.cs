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
    internal class MaterialManager : BaseManager<Material>, IMaterialService
    {
        public MaterialManager(IUow uow) : base(uow)
        {
        }

    
        public string QueryMaterial(string Name)
        {
            var repo = _uow.GetRepository<Material>();
            var query = repo.GetQueryable().Where(x=>x.Name == Name).ToList();
            var minstock=repo.GetQueryable().Where(x => x.Name == Name) .Select(entity=>entity.MinStock).First();
            var stock = repo.GetQueryable().Where(x=>x.Name==Name).Select(entity=>entity.Stock).First();
            if (stock <= minstock  ) 
            {
                return "stok az";
            }
            var str = Convert.ToString(stock);
            var minstr = Convert.ToString(minstock);
            return "minimum stok miktarınız: "+ minstr+ ", depoda bulunan stok: "+str  ;
           
        }
    }
}
