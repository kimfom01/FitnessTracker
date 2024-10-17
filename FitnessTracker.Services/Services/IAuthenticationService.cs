namespace FitnessTracker.CoreLogic.Services;

public interface IAuthenticationService
{
    void LoginUser(string username, string password);
    void RegisterUser(string username, string phoneNumber, string password);
    void ResetPassword(string username, string phoneNumber, string newPassword);
}