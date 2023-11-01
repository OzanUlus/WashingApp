using BA.CarWashingApp.Entity.Abstract;
using BA.CarWashingApp.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class SystemUser:BaseEntity
    {
        public SystemUser()
        {
            Employees = new();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public RoleType Role { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
