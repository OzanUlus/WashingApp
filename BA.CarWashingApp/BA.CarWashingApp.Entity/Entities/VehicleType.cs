﻿using BA.CarWashingApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.CarWashingApp.Entity.Entities
{
    public class VehicleType:BaseEntity
    {
        public VehicleType()
        {
            Vehicles = new();
        }
        public string TypeName { get; set; }
        public decimal TimeFactor { get; set; }
        public decimal PriceFactor { get; set; }
        public decimal MaterialFactor { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
