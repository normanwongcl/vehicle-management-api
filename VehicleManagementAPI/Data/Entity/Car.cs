using System;

namespace VehicleManagementAPI.Data.Entity
{
    public class Car : Vehicle
    {
        public BodyType BodyType { get; set; }
        public int NumOfDoors { get; set; }
    }


    public class BodyType
    {

        public int Id { get; set; }
        public string BodyName { get; set; }
    }
}
