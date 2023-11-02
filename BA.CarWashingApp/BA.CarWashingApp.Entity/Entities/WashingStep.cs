using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class WashingStep:BaseEntity
    {
        public string StepName { get; set; }
        public int StepTime { get; set; } //dakika
        public int WashingTypeId { get; set; }
        public WashingType WashingType { get; set; }
    }
}
