using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class Vehicle:BaseEntity
    {
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int OrderNo { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public int DirtStatusId { get; set; }
        public DirtStatus DirtStatus { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Washing Washing { get; set; }
        public int WashingId { get; set; }
    }
}
