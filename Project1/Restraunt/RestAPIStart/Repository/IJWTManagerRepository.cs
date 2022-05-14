using RestaurantModels;
namespace RestAPIStart.Repository
{
    public interface IJWTManagerRepository
    {
        TokensPassed Authenticate(UserForTokens user);
    }
}
