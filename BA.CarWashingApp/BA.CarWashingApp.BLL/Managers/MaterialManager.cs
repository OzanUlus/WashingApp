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

    
        public void QueryMaterial(string Name, Material entity)
        {
            var repo = _uow.GetRepository<Material>();
            var query = repo.GetQueryable().Where(x=>x.Name == Name).ToList();
            
        }
    }
}
