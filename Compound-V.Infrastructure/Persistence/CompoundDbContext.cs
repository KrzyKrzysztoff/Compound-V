﻿using Compound_V.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Persistence
{
    internal class CompoundDbContext(DbContextOptions<CompoundDbContext> options)
        : IdentityDbContext<User>(options)
    {
        internal DbSet<Domain.Entities.File> Files { get; set; }
        internal DbSet<Visit> Visits { get; set; }
        internal DbSet<Log> Logs { get; set; } 
        internal DbSet<Toothing> Toothings { get; set; }
    }
}
