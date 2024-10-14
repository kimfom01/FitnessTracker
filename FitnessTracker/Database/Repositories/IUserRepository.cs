using FitnessTracker.Models;

namespace FitnessTracker.Database.Repositories;

internal interface IUserRepository
{
    ApplicationUser AddUser(ApplicationUser newUser);
    bool CheckIfUserExist(string username);
    ApplicationUser? GetUser(string username);
}
