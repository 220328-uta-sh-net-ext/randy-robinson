using RestaurantModels;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RestAPIStart.Repository
{
    public class JWTManagerRepository : IJWTManagerRepository
    {
        private IConfiguration configuration;
        public JWTManagerRepository(IConfiguration configuration) { this.configuration = configuration; }
        Dictionary<string, string> UsersRecords = new Dictionary<string, string>()
        {
            {"Havelpot","thisTacoStand" },
            {"jumps", "toYr5" },
            {"user1", "password1" },
        };
        public TokensPassed Authenticate(UserForTokens user)
        {
            if(!UsersRecords.Any(t => t.Key== user.UserName && t.Value == user.Password))
            {
                return null;
            }
            //We need to check the Dictionary to see if the User exists from the Database
            var tokenHandler= new JwtSecurityTokenHandler();
            var tokenKey= Encoding.UTF8.GetBytes(configuration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                            new Claim(ClaimTypes.Name, user.UserName)

                    }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)

            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return new TokensPassed { Token = tokenHandler.WriteToken(token) }; 

        }
    }
}
