using RestaurantModels;
namespace RestAPIStart.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(UserForTokens user);
    }
}
