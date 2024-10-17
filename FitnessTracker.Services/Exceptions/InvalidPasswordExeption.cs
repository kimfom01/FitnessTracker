namespace FitnessTracker.CoreLogic.Exceptions;

public class InvalidPasswordExeption : Exception
{
    public InvalidPasswordExeption(string message) : base(message)
    {
    }
}
