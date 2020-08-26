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
        private CreateVehicleRequest FakeCreateRequestObject()
        {
            return new CreateVehicleRequest()
            {
                Make = "Toyota",
                Model = "Camry",
                Price = 100.00
            };
        }
        private IEnumerable<Vehicle> GetFakeVehicleLists()
        {
            return new List<Vehicle>
                {
                    new Vehicle()
                    {
                        Id = 1,
                        Make = "Toyota",
                        Model = "Camry",
                        Price = 100.00,
                        VehicleType = new VehicleType()
                        {
                            Id = 1,
                            VehicleName = "Car"
                        }
                    },
                    new Vehicle()
                    {
                        Id = 2,
                        Make = "Toyota",
                        Model = "Camry",
                        Price = 100.00,
                        VehicleType = new VehicleType()
                        {
                            Id = 2,
                            VehicleName = "Car"
                        }
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

        [Fact]
        public async Task GET_ById_RETURNS_OK()
        {
            long id = 1;

            _mockDataManager.Setup(manager => manager.GetByIdAsync(id))
               .ReturnsAsync(GetFakeVehicleLists().Single(p => p.Id.Equals(id)));

            var vehicle = await _controller.Get(id);
            Assert.IsType<VehicleQueryResponse>(vehicle);
        }

        [Fact]
        public async Task POST_Create_RETURNS_OK()
        {

            _mockDataManager.Setup(manager => manager.CreateAsync(It.IsAny<Vehicle>()))
                .ReturnsAsync(It.IsAny<long>());

            var vehicle = await _controller.Post(FakeCreateRequestObject());

            var response = Assert.IsType<ApiResponse>(vehicle);
            Assert.Equal(201, response.StatusCode);
        }

        [Fact]
        public async Task DELETE_ById_RETURNS_OK()
        {
            long id = 1;

            _mockDataManager.Setup(manager => manager.DeleteAsync(id))
                 .ReturnsAsync(true);

            var result = await _controller.Delete(id);

            var response = Assert.IsType<ApiResponse>(result);
            Assert.Equal(200, response.StatusCode);
        }

        [Fact]
        public async Task DELETE_ById_RETURNS_NOTFOUND()
        {
            var apiException = await Assert.ThrowsAsync<ApiProblemDetailsException>(() => _controller.Delete(1));
            Assert.Equal(404, apiException.StatusCode);
        }

        [Fact]
        public async Task DELETE_ById_RETURNS_SERVERERROR()
        {
            long id = 1;

            _mockDataManager.Setup(manager => manager.DeleteAsync(id))
                .Throws(new Exception());

            await Assert.ThrowsAsync<Exception>(() => _controller.Delete(id));
        }
    }

}