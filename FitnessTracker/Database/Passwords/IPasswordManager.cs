namespace FitnessTracker.Database.Passwords;

internal interface IPasswordManager
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hash);
}