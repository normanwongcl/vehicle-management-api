using AutoMapper;
using VehicleManagementAPI.Data.Entity;
using VehicleManagementAPI.DTO;
using VehicleManagementAPI.DTO.Response;
using VehicleManagementAPI.DTO.Request;

namespace VehicleManagementAPI.Infrastructure.Configs
{
    public class MappingProfileConfiguration : Profile
    {
        public MappingProfileConfiguration()
        {
            CreateMap<Vehicle, CreateVehicleRequest>().ReverseMap();
            CreateMap<Vehicle, UpdateVehicleRequest>().ReverseMap();
            CreateMap<Vehicle, VehicleQueryResponse>().ReverseMap();

        }
    }
}
