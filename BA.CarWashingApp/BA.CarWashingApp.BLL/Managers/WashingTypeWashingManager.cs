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
    public class WashingTypeWashingManager : BaseManager<WashingTypeWashing>, IWashingTypeWashingService
    {
        public WashingTypeWashingManager(IUow uow) : base(uow)
        {
        }
    }
}
