using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        //vardiya
        public DateTime ShiftStartTime { get; set; }
        public DateTime ShiftEndTime { get; set; }
        //Departman(Kayıt/Yıkama)
        public string Position { get; set; }
        public decimal Salary { get; set; }
        //izinler
        public int TotalLeave { get; set; }
        public int UsedLeave { get; set; }
        public int RemainingLeave { get; set; }
        public int SystemUserId { get; set; }
        public SystemUser SystemUser { get; set; }
        public Washing Washing { get; set; }
        public int WashingId { get; set; }

    }
}
