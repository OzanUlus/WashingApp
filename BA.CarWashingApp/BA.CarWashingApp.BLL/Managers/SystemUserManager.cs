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
        bool Permission(int id) { return true; }

        public decimal SetAmount(int washingtypeFactorId, int vehicletypeFactorId, int dirtFactorId, int washingrecipeId)
        {

            var metarial = _uow.GetRepository<WashingRecipe>().GetById(washingrecipeId).Amount;
            var washingtypefactor = _uow.GetRepository<WashingType>().GetById(washingtypeFactorId).MaterialFactor;
            var vehicletypefactor = _uow.GetRepository<VehicleType>().GetById(vehicletypeFactorId).MaterialFactor;
            var dirtfactor = _uow.GetRepository<DirtStatus>().GetById(dirtFactorId).MaterialFactor;
            decimal amount = metarial + (15 * washingtypefactor) + (15 * vehicletypefactor) + (15 * dirtfactor);

            return amount;
        }

        public decimal SetDuration(int vehicletypeFactorId, int dirtFactorId, int washingtypeId)
        {
            var washingDuration = _uow.GetRepository<WashingType>().GetById(washingtypeId).TypeTime;
            var dirtfactor = _uow.GetRepository<DirtStatus>().GetById(dirtFactorId).TimeFactor;
            var vehicletypefactor = _uow.GetRepository<VehicleType>().GetById(vehicletypeFactorId).TimeFactor;
            decimal Remainingtime = washingDuration + (10 * dirtfactor) + (10 * vehicletypefactor);
            return Remainingtime;

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

        bool ISystemUserService.Permission(int id)
        {
            throw new NotImplementedException();
        }
    }
}
