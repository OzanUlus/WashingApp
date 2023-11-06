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
    public class MaterialManager : BaseManager<Material>, IMaterialService
    {
        public MaterialManager(IUow uow) : base(uow)
        {
        }

        public Material GetByName(string Name)
        {
            var entity = _uow.GetRepository<Material>().GetQueryable().Where(x => x.Name == Name).FirstOrDefault();
            return entity;
        }

        public string QueryMaterial(string Name)
        {
            var repo = _uow.GetRepository<Material>();
            var query = repo.GetQueryable().Where(x=>x.Name == Name).FirstOrDefault();
            if (query != null)
            {
                var minstock = repo.GetQueryable().Where(x => x.Name == Name).Select(entity => entity.MinStock).First();
                var stock = repo.GetQueryable().Where(x => x.Name == Name).Select(entity => entity.Stock).First();
                if (stock <= minstock)
                {
                    return "Uyarı! Girdiğiniz Ürünün Stoğu Minimum Stok Miktarının Altına Düşmüştür!";
                }
                var str = Convert.ToString(stock);
                var minstr = Convert.ToString(minstock);
                return "minimum stok miktarınız: " + minstr + ", depoda bulunan stok: " + str;
            }
            return "Böyle bir ürün bulunamamıştır. Lütfen tekrar materyal ismi giriniz.";
           
        }
    }
}
