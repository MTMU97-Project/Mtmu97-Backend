using Microsoft.EntityFrameworkCore;
using Mtmu97.Infrastructure;
namespace Mtmu97.WebApi.Extensions
{
    public static class ConnectionConfiguration
    {
        public static void AddConnectionConfiguration(this IServiceCollection service, IConfiguration configuratioin )
        {
            var connectionString = configuratioin.GetConnectionString("DefaultConnection");
            service.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(connectionString));
        }
    }
}
