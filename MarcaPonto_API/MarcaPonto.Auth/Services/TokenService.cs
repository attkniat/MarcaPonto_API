using MarcaPonto.Auth.Interfaces;
using MarcaPonto.Model.Usuários;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace MarcaPonto.Auth.Services
{
    public class TokenService : IToken
    {
        public string GenerateToken(Customer customer)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
               {
                   new Claim(ClaimTypes.Email, customer.Email),
                   new Claim(ClaimTypes.Role, customer.Role),
               }),

                Expires = DateTime.UtcNow.AddHours(8),

                SigningCredentials = new SigningCredentials(
                                     new SymmetricSecurityKey(key),
                                         SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
