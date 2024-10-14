using FitnessTracker.Models;


namespace FitnessTracker.Database.Repositories;

internal interface IUserRepository
{
    ApplicationUser AddUser(ApplicationUser newUser);
    bool CheckIfUserExist(string username);
    ApplicationUser? GetUser(string username);
}

internal class UserRepository : IUserRepository
{
    public ApplicationUser AddUser(ApplicationUser newUser)
    {
        var dbContext = new FitnessContext();

        var addedEntry = dbContext.Add(newUser);
        dbContext.SaveChanges();

        return addedEntry.Entity;
    }

    public bool CheckIfUserExist(string username)
    {
        var dbContext = new FitnessContext();
        return dbContext.Users.FirstOrDefault(user => user.Username == username) is not null;
    }

    public ApplicationUser? GetUser(string username)
    {
        var dbContext = new FitnessContext();
        return dbContext.Users.FirstOrDefault(user => user.Username == username);
    }
}
