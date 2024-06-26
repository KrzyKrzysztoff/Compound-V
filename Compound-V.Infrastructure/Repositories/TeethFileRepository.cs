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
    public class TeethFileRepository(CompoundDbContext dbContext)
        : ITeethFileRepository
    {
        public async Task CreateTeethFile(Domain.Entities.File teethFile)
        {
            await dbContext.Files.AddAsync(teethFile);
            await dbContext.SaveChangesAsync();
        }
        public async Task DeleteTeethFile(Domain.Entities.File teethFile)
        {
            dbContext.Remove(teethFile);
            await dbContext.SaveChangesAsync();
        }

        public async Task<Domain.Entities.File?> GetTeethFileById(Guid teethFileId)
        {
            var teethFile = await dbContext.Files.FirstOrDefaultAsync(x => x.Id == teethFileId);
            return teethFile;
        }

        public async Task UpdateTeethFile(Domain.Entities.File teethFile)
        {
            dbContext.Files.Update(teethFile);
            await dbContext.SaveChangesAsync();
        }
    }
}
