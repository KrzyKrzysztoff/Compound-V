using Compound_V.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Persistence
{
    public class CompoundDbContext(DbContextOptions<CompoundDbContext> options)
        : IdentityDbContext<User>(options)
    {
        internal DbSet<Domain.Entities.File> Files { get; set; }
        internal DbSet<Visit> Visits { get; set; }
        internal DbSet<Log> Logs { get; set; } 
        internal DbSet<Teeth> Tooth { get; set; }
        internal DbSet<TeethType> ToothType { get; set; }
        internal DbSet<GenderType> GendersType { get; set; }
        internal DbSet<Address> Addresses { get; set; }
        internal DbSet<PaymentType> PaymentsType { get; set; }
        internal DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

        }
    }
}
