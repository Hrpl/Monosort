using Microsoft.EntityFrameworkCore;
using monosort.domain;

namespace monosort.api.Extensions;

public static class ServicesExtensions
{

    public static void AddServices(this IServiceCollection services)
    {

    }

    public static void AddDataBase(this WebApplicationBuilder builder, IConfiguration configuration)
    {
        builder.Services.AddDbContext<MonosortDbContext>(opts =>
        {
            opts.EnableDetailedErrors();
            opts.UseNpgsql(configuration.GetConnectionString("db.dev"));
        });
    }
}
