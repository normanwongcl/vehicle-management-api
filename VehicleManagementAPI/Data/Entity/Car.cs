using System;

namespace VehicleManagementAPI.Data.Entity
{
    public class Car : VehicleBase
    {
        public Type BodyType
        {
            get;
            set;
        }
        public int NumOfDoors { get; set; }
    }
}
