using FluentValidation;
using Compound_V.Application.User;
using Microsoft.Extensions.DependencyInjection;
using Compound_V.Application.User.Command;

namespace Compound_V.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var applicationAssembly = typeof(ServiceCollectionExtensions).Assembly;

            // Rejestracja wszystkich walidatorów z assembly
            services.AddValidatorsFromAssembly(applicationAssembly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(applicationAssembly));
            services.AddHttpContextAccessor();

            services.AddAutoMapper(applicationAssembly);

            services.AddScoped<IUserContext, UserContext>();
        }
    }
}
