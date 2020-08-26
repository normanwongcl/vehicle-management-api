using VehicleManagementAPI.Contracts;
using VehicleManagementAPI.DTO.Request;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VehicleManagementAPI.Infrastructure.Installers
{
    internal class RegisterModelValidators : IServiceRegistration
    {
        public void RegisterAppServices(IServiceCollection services, IConfiguration configuration)
        {
            //Register DTO Validators
            services.AddTransient<IValidator<CreatePersonRequest>, CreatePersonRequestValidator>();
            services.AddTransient<IValidator<CreateVehicleRequest>, CreateVehicleRequestValidator>();

            services.AddTransient<IValidator<UpdatePersonRequest>, UpdatePersonRequestValidator>();
            services.AddTransient<IValidator<UpdateVehicleRequest>, UpdateVehicleRequestValidator>();

            //Disable Automatic Model State Validation built-in to ASP.NET Core
            services.Configure<ApiBehaviorOptions>(opt => { opt.SuppressModelStateInvalidFilter = true; });
        }
    }
}
