using System;

namespace VehicleManagementAPI.Data.Entity
{
    public class VehicleBase : EntityBase
    {
        public long Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

    }
}