using JCH.Application.Features.Candidates;
using JCH.Infrastructure.DbContexts;
using JCH.Infrastructure.Modules.Candidates;
using JCH.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JCH.Infrastructure.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString(nameof(AppDbContext));

            options.UseSqlServer(connectionString);
        });

        return services
            .AddScoped<ICandidateRepository, CandidateRepository>()
            .AddScoped<IUnitOfWork, UnitOfWork>();
    }
}

