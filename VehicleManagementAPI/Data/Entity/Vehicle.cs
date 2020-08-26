using System;
using System.Collections.Generic;

namespace VehicleManagementAPI.Data.Entity
{
    public class Vehicle : EntityBase
    {
        public long Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public VehicleType VehicleType { get; set; }
    }

    public class VehicleType
    {

        public int Id { get; set; }
        public string VehicleName { get; set; }
    }
}

