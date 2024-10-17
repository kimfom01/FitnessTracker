﻿namespace FitnessTracker.Passwords;

public interface IPasswordManager
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hash);
}