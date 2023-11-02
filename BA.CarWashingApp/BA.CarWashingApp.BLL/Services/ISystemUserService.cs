using BA.CarWashingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Services
{
    public interface ISystemUserService : IService<SystemUser>
    {
        
       
        //izinver
       public bool Permission(int id, int requestpermission);
        //süre
        decimal SetDuration(int vehicletypeFactorId, int dirtFactorId, int washingtypeId);
        //amount
        decimal SetAmount(int washingtypeFactorId, int vehicletypeFactorId, int dirtFactorId, int washingrecipeId);
        //price
        decimal SetPrice(int factor1, int factor2, int factor3, int WashingtypeId);

    }
}
