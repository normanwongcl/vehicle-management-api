using FluentValidation;
using System;

namespace VehicleManagementAPI.DTO.Request
{
    public class CreateVehicleRequest
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }

    public class CreateVehicleRequestValidator : AbstractValidator<CreateVehicleRequest>
    {
        public CreateVehicleRequestValidator()
        {
            RuleFor(o => o.Make).NotEmpty();
            RuleFor(o => o.Model).NotEmpty();
            RuleFor(o => o.Price).NotEmpty();
        }
    }
}
