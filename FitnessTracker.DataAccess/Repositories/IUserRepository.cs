using FitnessTracker.Domain;

namespace FitnessTracker.DataAccess.Repositories;

public interface IUserRepository
{
    ApplicationUser AddUser(ApplicationUser newUser);
    bool CheckIfPhoneNumberExists(string username, string phoneNumber);
    bool CheckIfUserExist(string username);
    ApplicationUser? GetUser(string username);

    public void SaveChanges();
}
