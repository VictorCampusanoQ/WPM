using Microsoft.EntityFrameworkCore;

namespace Wpm.Web.Dal;

public static class WpmDbContextExtensions
{
    public static void AddWpmDb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<WpmDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("Wpm"));
        });
    }
}