﻿using FitnessTracker.CoreLogic.Exceptions;
using FitnessTracker.CoreLogic.Passwords;
using FitnessTracker.DataAccess.Repositories;

namespace FitnessTracker.CoreLogic.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IPasswordManager _passwordManager;
    private readonly IUserRepository _userRepository;

    private const int MaxLoginAttempts = 3;
    private const int NoAttempts = 0;

    public AuthenticationService(
        IPasswordManager passwordManager,
        IUserRepository userRepository
    )
    {
        _passwordManager = passwordManager;
        _userRepository = userRepository;
    }

    public bool LoginUser(string username, string password)
    {
        var user = _userRepository.GetUser(username);

        if (user is null)
        {
            throw new NotFoundException("Invalid username or password");
        }

        if (user.IsLocked)
        {
            throw new AccountLockedException("Your account is locked. Please reset your password!");
        }

        if (!_passwordManager.VerifyPassword(password, user.Password))
        {
            if (user.LoginAttempts == NoAttempts)
            {
                user.LockAccount();
                _userRepository.SaveChanges();

                throw new AccountLockedException("Your account is locked. Please reset your password!");
            }

            user.UpdateLoginAttempts();
            _userRepository.SaveChanges();

            throw new InvalidPasswordExeption("Invalid username or password");
        }

        if (user.LoginAttempts < MaxLoginAttempts)
        {
            user.ResetLoginAttempts();
            _userRepository.SaveChanges();
        }

        return true;
    }
}