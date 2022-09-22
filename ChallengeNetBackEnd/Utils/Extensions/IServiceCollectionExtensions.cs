using ChallengeNetBackEnd.Data.Implementations;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ChallengeNetBackEnd.Utils.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void SetDatabaseConfig(this IServiceCollection service, ConfigurationManager config)
        {
            string connectionString = config["ConnectionStrings:ChallegeDB"];
            if (!string.IsNullOrEmpty(connectionString))
            {
                var builder = new NpgsqlConnectionStringBuilder(connectionString);
                service.AddDbContext<DataContext>(opt => opt.UseNpgsql(builder.ConnectionString));
            }
        } 
    }
}
