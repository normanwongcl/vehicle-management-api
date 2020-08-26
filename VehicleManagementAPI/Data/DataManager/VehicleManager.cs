using VehicleManagementAPI.Contracts;
using VehicleManagementAPI.Data.Entity;
using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace VehicleManagementAPI.Data.DataManager
{
    public class VehicleManager : DbFactoryBase, IVehicleManager
    {

        private readonly ILogger<VehicleManager> _logger;
        public VehicleManager(IConfiguration config, ILogger<VehicleManager> logger) : base(config)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<Vehicle>> GetAllAsync()
        {
            return await DbQueryAsync<Vehicle>("SELECT * FROM Vehicle");
        }

        public async Task<Vehicle> GetByIdAsync(object id)
        {
            return await DbQuerySingleAsync<Vehicle>("SELECT * FROM Vehicle WHERE ID = @ID;", new { id });
        }

        public async Task<long> CreateAsync(Vehicle vehicle)
        {
            string sqlQuery = $@"INSERT INTO Vehicle (Make, Model, Price) 
                                     VALUES (@Make, @Model, @Price)
                                     SELECT CAST(SCOPE_IDENTITY() as bigint);";

            return await DbQuerySingleAsync<long>(sqlQuery, vehicle);
        }
        public async Task<bool> UpdateAsync(Vehicle vehicle)
        {
            string sqlQuery = $@"IF EXISTS (SELECT 1 FROM Vehicle WHERE ID = @ID) 
                                            UPDATE Vehicle SET Make = @Make, Model = @Model, Price = @Price
                                            WHERE ID = @ID";

            return await DbExecuteAsync<bool>(sqlQuery, vehicle);
        }
        public async Task<bool> DeleteAsync(object id)
        {
            string sqlQuery = $@"IF EXISTS (SELECT 1 FROM Vehicle WHERE ID = @ID)
                                        DELETE Vehicle WHERE ID = @ID";

            return await DbExecuteAsync<bool>(sqlQuery, new { id });
        }
        public async Task<bool> ExistAsync(object id)
        {
            return await DbExecuteScalarAsync("SELECT COUNT(1) FROM Vehicle WHERE ID = @ID", new { id });
        }

    }
}