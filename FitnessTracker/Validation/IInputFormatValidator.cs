﻿namespace FitnessTracker.Validation;

public interface IInputFormatValidator
{
    bool ValidatePasswordFormat(string password);
    bool ValidatePasswordLength(string password);
    bool ValidatePhoneNumber(string phoneNumber);
    bool ValidateUsername(string username);
}