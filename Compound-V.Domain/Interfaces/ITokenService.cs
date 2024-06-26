﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(string userId, IEnumerable<string>? roles);
    }
}
