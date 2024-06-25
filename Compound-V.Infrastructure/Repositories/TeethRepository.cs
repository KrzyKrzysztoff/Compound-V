﻿using Compound_V.Domain.Entities;
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

        public async Task CreateTeethType(TeethType teethType)
        {
            await dbContext.ToothType.AddAsync(teethType);
            await dbContext.SaveChangesAsync();
        }

        public Task CreateTeethType(Teeth teeth)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteTeeth(Teeth teeth)
        {
            dbContext.Remove(teeth);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteTeethType(TeethType teethType)
        {
            dbContext.Remove(teethType);
            await dbContext.SaveChangesAsync();
        }
        public async Task<Teeth?> GetTeethById(Guid teethId)
        {
            var teeth = await dbContext.Tooth.FirstOrDefaultAsync(x=>x.Id == teethId);
            return teeth;
        }

        public async Task<TeethType?> GetTeethTypeById(Guid teethTypeId)
        {
            var tooth = await dbContext.ToothType.FirstOrDefaultAsync(x => x.Id == teethTypeId);
            return tooth;
        }

        public async Task UpdateTeeth(Teeth teeth)
        {
            dbContext.Tooth.Update(teeth);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateTeethType(TeethType teethType)
        {
            dbContext.ToothType.Update(teethType);
            await dbContext.SaveChangesAsync();
        }

    }
}
