using FitnessTracker.Models;

namespace FitnessTracker.Database.Repositories;

internal class UserRepository : IUserRepository
{
    private readonly FitnessContext _fitnessContext;

    public UserRepository(FitnessContext fitnessContext)
    {
        _fitnessContext = fitnessContext;
    }

    public ApplicationUser AddUser(ApplicationUser newUser)
    {
        var addedEntry = _fitnessContext.Add(newUser);
        return addedEntry.Entity;
    }

    public bool CheckIfPhoneNumberExists(string username, string phoneNumber)
    {
        return _fitnessContext.Users
            .Where(user => user.Username == username)
            .Where(user => user.PhoneNumber == phoneNumber)
            .Any();
    }

    public bool CheckIfUserExist(string username)
    {
        return _fitnessContext.Users.Any(u => u.Username == username);
    }

    public ApplicationUser? GetUser(string username)
    {
        return _fitnessContext.Users.FirstOrDefault(user => user.Username == username);
    }

    public void SaveChanges()
    {
        _fitnessContext.SaveChanges();
    }
}
