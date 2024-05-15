using Compound_V.Domain.Entities;
using Compound_V.Infrastructure.Persistence;
using Compound_V.Infrastructure.Seeders;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("CompoundDb");

            serviceCollection.AddDbContext<CompoundDbContext>(
                x => x.UseSqlServer(connectionString));

            serviceCollection.AddIdentityApiEndpoints<User>()
              .AddRoles<IdentityRole>()
              .AddEntityFrameworkStores<CompoundDbContext>();

            serviceCollection.AddScoped<ICompoundSeed,  CompoundSeed>();
        }
    }
}
