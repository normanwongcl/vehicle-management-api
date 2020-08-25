using VehicleManagementAPI.Data;
using VehicleManagementAPI.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Contracts
{
    public interface IVehicleManager : IRepository<Vehicle>
    {

        //Add more class specific methods here when neccessary
    }
}
