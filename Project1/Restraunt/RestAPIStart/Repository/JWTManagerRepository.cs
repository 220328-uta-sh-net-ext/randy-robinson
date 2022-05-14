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
        public DataTokensMetadata Authenticate(UserForTokens user)
    }
}
