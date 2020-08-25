using System;
using System.Collections.Generic;

namespace VehicleManagementAPI.DTO.Response
{
    public class VehicleQueryResponse
    {
        public long Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}
