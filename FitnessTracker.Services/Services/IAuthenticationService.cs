namespace FitnessTracker.CoreLogic.Services
{
    public interface IAuthenticationService
    {
        bool LoginUser(string username, string password);
    }
}