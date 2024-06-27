using Compound_V.Domain.Interfaces;
using Compound_V.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Repositories
{
    public class DbRepository(CompoundDbContext dbContext)
        : IDbRepository
    {
        public async Task SaveChanges() => await dbContext.SaveChangesAsync();
        
    }
}
