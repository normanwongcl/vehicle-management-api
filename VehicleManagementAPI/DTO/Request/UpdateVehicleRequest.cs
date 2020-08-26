using VehicleManagementAPI.Infrastructure.Helpers;
using FluentValidation;
using System;

namespace VehicleManagementAPI.DTO.Request
{
    public class UpdateVehicleRequest
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }

    public class UpdateVehicleRequestValidator : AbstractValidator<UpdateVehicleRequest>
    {
        public UpdateVehicleRequestValidator()
        {
            RuleFor(o => o.Make).NotEmpty();
            RuleFor(o => o.Model).NotEmpty();
            RuleFor(o => o.Price).NotEmpty();
        }
    }
}
