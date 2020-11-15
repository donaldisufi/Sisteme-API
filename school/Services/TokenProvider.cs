using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace school.Models
{
    public static class TokenProvider
    {
        public static string SecurityKey = "UYmqPbPcQqkSsYqWTKBTxym4xe0qo6NdQ9R3rBUxoH1My6ycStrzDwZDAKHiOHTX51UaTElwIyXVdHzGryO2uQZq7ebaXEKv6U3m";

        public static string GenerateToken(User user)
        {
            var secretBytes = Encoding.ASCII.GetBytes(SecurityKey);

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            SymmetricSecurityKey key = new SymmetricSecurityKey(secretBytes);

            SecurityTokenDescriptor descriptor = new SecurityTokenDescriptor()
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Email, user.UserName),
                    new Claim(ClaimTypes.Name, user.Id.ToString()),
                }),
                Expires = DateTime.Now.AddMinutes(2),
                SigningCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256Signature)
            };

            JwtSecurityToken token = handler.CreateJwtSecurityToken(descriptor);

            return handler.WriteToken(token);
        }
    }
}
