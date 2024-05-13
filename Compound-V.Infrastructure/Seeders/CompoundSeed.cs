using Compound_V.Domain.Entities;
using Compound_V.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Seeders
{
    internal class CompoundSeed(CompoundDbContext compoundDbContext,
        UserManager<User> userManager) : ICompoundSeed
    {
        public async Task Seed()
        {

            if (compoundDbContext.Database.GetPendingMigrations().Any())
            {
                await compoundDbContext.Database.MigrateAsync();
            }

            if (compoundDbContext.Database.CanConnect())
            {
                if (!compoundDbContext.Logs.Any())
                {
                    var logs = GetLogs();

                    await compoundDbContext.Logs.AddRangeAsync(logs);

                    await compoundDbContext.SaveChangesAsync();
                }
            }

            if (!compoundDbContext.Users.Any())
            {
                var users = GetUsers();

                if (users.Any())
                {
                    foreach (var user in users)
                    {
                        await userManager.CreateAsync(user, "Test123#@!");
                    }
                }
            }
        }

        public List<Log> GetLogs()
        {
            List<Log> logs = new List<Log>()
            {
                new Log() { CreateDate = DateTime.Now, Exception = nameof(NullReferenceException), StackTrace = "test" },
                new Log() { CreateDate = DateTime.Now, Exception = nameof(StackOverflowException), StackTrace = "test" },
                new Log() { CreateDate = DateTime.Now, Exception = nameof(DivideByZeroException), StackTrace = "test" },
            };

            return logs;
        }

        public List<User> GetUsers()
        {
            var users = new List<User>()
            {
                new User(){
                    Email = "test@wp.pl",
                    NormalizedEmail = "TEST@WP.PL",
                    UserName = "John",
                    NormalizedUserName = "JHON"
                },
                 new User(){
                    Email = "test2@wp.pl",
                    NormalizedEmail = "TEST2@WP.PL",
                    UserName = "John2",
                    NormalizedUserName = "JHON2"
                },
            };

            return users;
        }
    }
}
