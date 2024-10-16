namespace FitnessTracker.DataAccess.Entities;

public class ApplicationUser : BaseEntity
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string PhoneNumber { get; private set; }
    public int LoginAttempts { get; private set; }
    public bool IsLocked { get; private set; }

    private ApplicationUser(string username, string password, string phoneNumber)
    {
        Username = username;
        Password = password;
        PhoneNumber = phoneNumber;
    }

    public static ApplicationUser Create(string username, string password, string phoneNumber)
    {
        return new ApplicationUser(username, password, phoneNumber);
    }

    public void UpdateLoginAttempts()
    {
        LoginAttempts--;
    }

    public void ResetLoginAttempts()
    {
        LoginAttempts = 3;
    }

    public void LockAccount()
    {
        IsLocked = true;
    }

    public void UnLockAccount()
    {
        ResetLoginAttempts();
        IsLocked = false;
    }

    public void UpdatePassword(string password)
    {
        Password = password;
    }
}