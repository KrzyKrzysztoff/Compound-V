using Compound_V.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Interfaces
{
    public interface ITeethRepository
    {
        Task CreateTeeth(Teeth teeth);
    }
}
