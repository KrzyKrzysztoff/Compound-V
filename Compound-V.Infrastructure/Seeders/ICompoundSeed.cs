using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Infrastructure.Seeders
{
    public interface ICompoundSeed
    {
        Task Seed();
    }
}
