﻿namespace FitnessTracker.CoreLogic.Validation;

public interface IInputFormatValidator
{
    bool ValidatePasswordFormat(string password);
    bool ValidatePasswordLength(string password);
    bool ValidatePhoneNumber(string phoneNumber);
    bool ValidateUsername(string username);
    bool ValidateNumberDouble(string number);
    bool ValidateNumberInt(string number);
}