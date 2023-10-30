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
    public class SystemUserManager : BaseManager<SystemUser>, ISystemUserService
    {
        public SystemUserManager(IUow uow) : base(uow)
        {
        }

        public void AddAdmin(string Name, string Surname, Enum RoleType)
        {
            throw new NotImplementedException();
        }

        public bool AddEmployeeToApp(string Name, string Password, string Position, Enum RoleType)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public decimal SetPrice(int factor1, int factor2, int factor3, int WashingtypeId)
        {
  
            var washingprice= _uow.GetRepository<WashingType>().GetById(WashingtypeId).TypePrice;
            var dirtfactor = _uow.GetRepository<DirtStatus>().GetById(factor1).PriceFactor;
            var vehicletypefactor = _uow.GetRepository<VehicleType>().GetById(factor2).PriceFactor;
            var recipefactor = _uow.GetRepository<WashingRecipe>().GetById(factor3).PriceFactor;

            decimal TotalPrice = washingprice+(100*dirtfactor)+(100*vehicletypefactor)+(100*recipefactor);
            return TotalPrice;

        }
    }
}
