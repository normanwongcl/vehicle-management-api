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
    public class VehiclesControllerTests
    {
        private readonly Mock<IVehicleManager> _mockDataManager;
        private readonly VehiclesController _controller;

        public VehiclesControllerTests()
        {
            var logger = Mock.Of<ILogger<VehiclesController>>();

            var mapperProfile = new MappingProfileConfiguration();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(mapperProfile));
            var mapper = new Mapper(configuration);

            _mockDataManager = new Mock<IVehicleManager>();

            _controller = new VehiclesController(_mockDataManager.Object, mapper, logger);
        }
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


        [Fact]
        public async Task GET_All_RETURNS_OK()
        {

            // Arrange
            _mockDataManager.Setup(manager => manager.GetAllAsync())
               .ReturnsAsync(GetFakeVehicleLists());

            // Act
            var result = await _controller.Get();

            // Assert
            var vehicles = Assert.IsType<List<VehicleQueryResponse>>(result);
            Assert.Equal(2, vehicles.Count);
        }
    }
}