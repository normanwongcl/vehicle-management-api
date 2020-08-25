using System;

namespace VehicleManagementAPI.Data.Entity
{
    public class Car : Vehicle
    {
        public Type BodyType
        {
            get;
            set;
        }
        public int NumOfDoors { get; set; }
    }
}
