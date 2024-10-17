using System.Text.RegularExpressions;

namespace FitnessTracker.CoreLogic.Validation;

public partial class InputFormatValidator : IInputFormatValidator
{
    public bool ValidatePasswordLength(string password)
    {
        if (password.Length > 12)
        {
            return false;
        }

        return true;
    }

    public bool ValidatePasswordFormat(string password)
    {
        var foundLower = false;
        var foundUpper = false;

        foreach (var ch in password)
        {
            if (!char.IsLetter(ch))
            {
                continue;
            }

            if (char.IsUpper(ch))
            {
                foundUpper = true;
            }

            if (char.IsLower(ch))
            {
                foundLower = true;
            }

            if (foundLower && foundUpper)
            {
                return true;
            }
        }

        return false;
    }

    public bool ValidateUsername(string username)
    {
        foreach (var ch in username)
        {
            if (!char.IsLetterOrDigit(ch))
            {
                return false;
            }
        }

        return true;
    }

    public bool ValidatePhoneNumber(string phoneNumber)
    {
        var regex = PhoneNumberRegex();

        return regex.IsMatch(phoneNumber);
    }

    [GeneratedRegex(@"^\d{10}$")]
    private static partial Regex PhoneNumberRegex();
}
