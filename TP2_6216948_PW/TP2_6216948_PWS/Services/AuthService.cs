using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TP2_6216948_PWS.Models;

namespace TP2_6216948_PWS.Services
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        public AuthService(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;

        }
        public async Task<(int, string)> Registeration(RegisterDTO model, string role)
        {
            var userExists = await userManager.FindByNameAsync(model.Username);
            if (userExists != null)
                return (0, "User already exists");

            User user = new User()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var createUserResult = await userManager.CreateAsync(user, model.Password);
            if (!createUserResult.Succeeded)
                return (0, "User creation failed! Please check user details and try again.");

            if (!await roleManager.RoleExistsAsync(role))
                await roleManager.CreateAsync(new IdentityRole(role));

            if (await roleManager.RoleExistsAsync(UsersRoles.User))
                await userManager.AddToRoleAsync(user, role);

            return (1, "User created successfully!");
        }

        public async Task<JwtSecurityToken> Login(LoginDTO model)
        {
            var user = await userManager.FindByNameAsync(model.Username);
            if (user == null)
                return null;
            if (!await userManager.CheckPasswordAsync(user, model.Password))
                return null;

            var userRoles = await userManager.GetRolesAsync(user);
            var authClaims = new List<Claim>();
            

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }
            authClaims.Add(new Claim(ClaimTypes.NameIdentifier,user.Id));
            JwtSecurityToken token = GenerateToken(authClaims);
            return token;
             
        }


        private JwtSecurityToken GenerateToken(List<Claim> claims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));


            JwtSecurityToken token = new JwtSecurityToken(

                issuer: _configuration["JWT:ValidIssuer"],
                audience : _configuration["JWT:ValidAudience"],
                expires: DateTime.UtcNow.AddHours(3),
                signingCredentials : new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256),
                claims : claims



            );

            var tokenHandler = new JwtSecurityTokenHandler();

            return token;
        }
    }

}
