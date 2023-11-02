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

        //Login işlemleri

        //1.güçlü şifre
         bool IsStrongPassword(string password);
        //2. özel karakter kontrol
        bool IsSpecialCharacter(char character);
        //3.Email kontrolü(kullanici email ile giriş yapacaksa!!!! yoksa değiştiririz-cansin)
        bool IsValidEmail(string email);
        //kullanici adı db de var mı yani unique mi
        bool IsUserExist(string username);
        //login işlemi kontrolü(int döndürdüm=> giriş yapanın id si elimizde olsun )
        int IsAccountTrue(string username, string password);


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
