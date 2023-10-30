﻿using BA.CarWashingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.BLL.Services
{
    public interface ISystemUserService : IService<SystemUser>
    {
        
        void AddAdmin(string Name, string Surname, Enum RoleType);
        bool AddEmployeeToApp(string Name, string Password, string Position, Enum RoleType);
        bool Login(string username, string password);
        //izinver
     
        //süre
        //amount
        decimal SetPrice(int factor1, int factor2, int factor3, int WashingtypeId);

    }
}