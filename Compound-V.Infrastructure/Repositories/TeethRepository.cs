using Compound_V.Domain.Entities;
using Compound_V.Domain.Interfaces;
using Compound_V.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Repositories
{
    public class TeethRepository(CompoundDbContext dbContext)
        : ITeethRepository
    {
        public async Task CreateTeeth(Teeth teeth)
        {
            await dbContext.Tooth.AddAsync(teeth);
            await dbContext.SaveChangesAsync();
        }
        public async Task DeleteTeeth(Teeth teeth)
        {
            dbContext.Remove(teeth);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Teeth?> GetTeethById(Guid teethId)
        {
            var teeth = await dbContext.Tooth.FirstOrDefaultAsync(x=>x.Id == teethId);
            return teeth;
        }

        public async Task UpdateTeeth(Teeth teeth)
        {
            dbContext.Tooth.Update(teeth);
            await dbContext.SaveChangesAsync();
        }
    }
}
