using VehicleManagementAPI.API.v1;
using VehicleManagementAPI.Contracts;
using VehicleManagementAPI.Data.Entity;
using VehicleManagementAPI.DTO.Response;
using VehicleManagementAPI.DTO.Request;
using VehicleManagementAPI.Infrastructure.Configs;
using AutoMapper;
using AutoWrapper.Wrappers;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace VehicleManagementAPI.Test.v1
{
    public class VehiclesControllerTest
    {
        private IEnumerable<VehicleBase> GetFakeVehicleLists()
        {
            return new List<VehicleBase>
                {
                    new VehicleBase()
                    {
                        Id = 1,
                        Make = "Toyota",
                        Model = "Camry",
                        Price = 100.00
                    },
                    new VehicleBase()
                    {
                        Id = 2,
                        Make = "Toyota",
                        Model = "Camry",
                        Price = 100.00
                    }
                };
        }
    }
}