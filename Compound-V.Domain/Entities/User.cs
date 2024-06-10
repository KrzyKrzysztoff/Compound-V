using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_V.Domain.Entities
{
    public class User : IdentityUser
    {
        public DateTime CreateDate { get; set; }
        public string? ProfilePhotoPath { get; set; }
        public DateTime DateOfBirth { get; set; }

        public GenderType? GendersType { get; set; }
        public Address? Addresses { get; set; }
    }
}
