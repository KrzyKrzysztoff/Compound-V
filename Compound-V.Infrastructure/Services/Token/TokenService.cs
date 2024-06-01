using Compound_V.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Compound_V.Application.User;
using Compound_V.Domain.Interfaces;
using Compound_V.Application.Dtos;

namespace Compound_V.Infrastructure.Services.Token
{
    public class TokenService(IConfiguration _configuration,
        IUserContext userContext)
        : ITokenService
    {

        public string CreateToken(string userId, IEnumerable<string>? roles)
        {
            try
            {
                var claims = new List<Claim>
                {
                    new Claim("userId", userId),
                    new Claim(ClaimTypes.Role, "admin"),
                };

                //if (roles != null)
                //    claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));


                var tokenHandler = new JwtSecurityTokenHandler();

                var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]!);
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(claims),
                    Expires = DateTime.UtcNow.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                    Issuer = _configuration["Jwt:Issuer"],
                    Audience = _configuration["Jwt:Audience"]
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                return tokenHandler.WriteToken(token);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return string.Empty;
        }
    }
}
