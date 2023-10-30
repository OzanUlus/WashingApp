using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class WashingType:BaseEntity
    {
        public WashingType()
        {
            WashingTypeWashings = new();
            WashingSteps = new();
        }
        public string TypeName { get; set; }
        public int TypeTime { get; set; } //Dakika
        public decimal TypePrice { get; set; }
        public decimal MaterialFactor { get; set; }
        public List<WashingTypeWashing> WashingTypeWashings { get; set; }
        public List<WashingStep> WashingSteps { get; set; }

    }
}
