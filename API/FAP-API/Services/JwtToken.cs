using FAP_API.ModelDTO;
using FAP_API.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FAP_API.Services
{
    public class JwtToken(IConfiguration _configuration, Prm392Context _context)
    {
        public string GenarateToken(LoginInfo userLogin) {
            try
            {
                var user = _context.Users.FirstOrDefault(x => x.Email == userLogin.Email);
                if (user == null) throw new Exception("Email not valid.");
                if (user.IsDelete == true) throw new Exception("Account has been disabled"); 
                if (!user.Password.Trim().Equals(userLogin.Password.Trim())) throw new Exception("Wrong password.");
                var cliam = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };
                Constants.UserRoleEnum.UserRoleE roleEnum = (Constants.UserRoleEnum.UserRoleE)user.Role;
                cliam.Add(new Claim(ClaimTypes.Role, roleEnum.ToString()));

                var jwtKey = _configuration.GetValue<string>("JwtConfig:key");
                var jwtIssuer = _configuration.GetValue<string>("JwtConfig:issuer");
                var jwtAudience = _configuration.GetValue<string>("JwtConfig:audience");
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
                var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    issuer: jwtIssuer,
                    audience: jwtAudience,
                    claims: cliam,
                    expires: DateTime.UtcNow.AddDays(7),
                    signingCredentials: cred);
                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }
    }
}
