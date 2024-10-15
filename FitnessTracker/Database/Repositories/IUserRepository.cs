using FitnessTracker.Models;

namespace FitnessTracker.Database.Repositories;

internal interface IUserRepository
{
    ApplicationUser AddUser(ApplicationUser newUser);
    bool CheckIfPhoneNumberExists(string username, string phoneNumber);
    bool CheckIfUserExist(string username);
    ApplicationUser? GetUser(string username);

    public void SaveChanges();
}
