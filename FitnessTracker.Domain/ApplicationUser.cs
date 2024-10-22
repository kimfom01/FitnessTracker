using FitnessTracker.Domain.Activities;

namespace FitnessTracker.Domain;

public class ApplicationUser : BaseEntity
{
    public string Username { get; private set; }
    public string Password { get; private set; }
    public string PhoneNumber { get; private set; }
    public int LoginAttempts { get; private set; }
    public bool IsLocked { get; private set; }

    public IReadOnlyList<Goal> Goals { get; private set; }
    public IReadOnlyList<Walking> Walkings { get; private set; }
    public IReadOnlyList<Swimming> Swimmings { get; private set; }
    public IReadOnlyList<Cycling> Cyclings { get; private set; }
    public IReadOnlyList<Running> Runnings { get; private set; }
    public IReadOnlyList<WeightLifting> WeightLiftings { get; private set; }

    private ApplicationUser(string username, string password, string phoneNumber)
    {
        Username = username;
        Password = password;
        PhoneNumber = phoneNumber;
        Goals = new List<Goal>();
        Walkings = new List<Walking>();
        Swimmings = new List<Swimming>();
        Cyclings = new List<Cycling>();
        Runnings = new List<Running>();
        WeightLiftings = new List<WeightLifting>();
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