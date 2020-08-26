using VehicleManagementAPI.Contracts;
using VehicleManagementAPI.Data;
using VehicleManagementAPI.Data.Entity;
using VehicleManagementAPI.DTO.Request;
using VehicleManagementAPI.DTO.Response;
using AutoMapper;
using AutoWrapper.Extensions;
using AutoWrapper.Wrappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace VehicleManagementAPI.API.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly ILogger<VehiclesController> _logger;
        private readonly IVehicleManager _vehicleManager;
        private readonly IMapper _mapper;

        public VehiclesController(IVehicleManager vehicleManager, IMapper mapper, ILogger<VehiclesController> logger)
        {
            _vehicleManager = vehicleManager;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<VehicleQueryResponse>), Status200OK)]
        public async Task<IEnumerable<VehicleQueryResponse>> Get()
        {
            var data = await _vehicleManager.GetAllAsync();
            var vehicles = _mapper.Map<IEnumerable<VehicleQueryResponse>>(data);

            return vehicles;
        }

        [Route("{id:long}")]
        [HttpGet]
        [ProducesResponseType(typeof(PersonQueryResponse), Status200OK)]
        [ProducesResponseType(typeof(PersonQueryResponse), Status404NotFound)]
        public async Task<VehicleQueryResponse> Get(long id)
        {
            var vehicle = await _vehicleManager.GetByIdAsync(id);
            return vehicle != null ? _mapper.Map<VehicleQueryResponse>(vehicle)
                                  : throw new ApiProblemDetailsException($"Record with id: {id} does not exist.", Status404NotFound);
        }
        [HttpPost]
        [ProducesResponseType(typeof(ApiResponse), Status201Created)]
        [ProducesResponseType(typeof(ApiResponse), Status422UnprocessableEntity)]
        public async Task<ApiResponse> Post([FromBody] CreateVehicleRequest createRequest)
        {
            if (!ModelState.IsValid) { throw new ApiProblemDetailsException(ModelState); }

            var vehicle = _mapper.Map<Vehicle>(createRequest);
            return new ApiResponse("Record successfully created.", await _vehicleManager.CreateAsync(vehicle), Status201Created);
        }
    }
}