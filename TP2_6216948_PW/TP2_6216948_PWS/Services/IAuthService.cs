using System.IdentityModel.Tokens.Jwt;
using TP2_6216948_PWS.Models;

namespace TP2_6216948_PWS.Services
{
    public interface IAuthService
    {
       public Task<(int, string)> Registeration(RegisterDTO model, string role);
       public Task<JwtSecurityToken> Login(LoginDTO model);
    }
}
