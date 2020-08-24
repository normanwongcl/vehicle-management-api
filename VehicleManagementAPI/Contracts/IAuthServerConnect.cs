using System.Threading.Tasks;

namespace VehicleManagementAPI.Contracts
{
    public interface IAuthServerConnect
    {
        Task<string> RequestClientCredentialsTokenAsync();
    }
}
