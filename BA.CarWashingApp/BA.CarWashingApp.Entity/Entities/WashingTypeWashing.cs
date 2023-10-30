using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class WashingTypeWashing:BaseEntity
    {
        public int WashingTypeId { get; set; }
        public int WashingId { get; set; }
        public Washing Washing { get; set; }
        public WashingType WashingType { get; set; }
    }
}
