using Compound_V.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Interfaces
{
    public interface ITeethFileRepository
    {
        Task CreateTeethFile(Entities.File teethFile);
        Task DeleteTeethFile(Entities.File teethFile);
        Task UpdateTeethFile(Entities.File teethFile);
        Task<Entities.File?> GetTeethFileById(Guid teethFileId);
    }
}
