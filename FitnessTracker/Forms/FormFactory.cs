using FitnessTracker.DataAccess.Repositories;
using FitnessTracker.DataAccess;
using FitnessTracker.CoreLogic.Passwords;
using FitnessTracker.CoreLogic.Validation;
using FitnessTracker.CoreLogic.Services;

namespace FitnessTracker.Forms;

public static class FormFactory
{
    public static LoginForm CreateLoginForm()
    {
        var dbContext = new FitnessContext();

        IInputFormatValidator _inputFormatValidator = new InputFormatValidator();
        IPasswordManager _passwordManager = new PasswordManager();
        IUserRepository _userRepository = new UserRepository(dbContext);
        IAuthenticationService authenticationService = new AuthenticationService(_passwordManager, _userRepository);

        return new LoginForm(authenticationService, _inputFormatValidator);
    }

    public static RegistrationForm CreateRegistrationForm()
    {
        var dbContext = new FitnessContext();

        IInputFormatValidator _inputFormatValidator = new InputFormatValidator();
        IPasswordManager _passwordManager = new PasswordManager();
        IUserRepository _userRepository = new UserRepository(dbContext);
        IAuthenticationService authenticationService = new AuthenticationService(_passwordManager, _userRepository);

        return new RegistrationForm(authenticationService, _inputFormatValidator);
    }

    public static ResetPasswordForm CreateResetPasswordForm(string username)
    {
        var dbContext = new FitnessContext();

        var _inputFormatValidator = new InputFormatValidator();
        var _passwordManager = new PasswordManager();
        var _userRepository = new UserRepository(dbContext);

        return new ResetPasswordForm(_inputFormatValidator, _passwordManager, _userRepository, username);
    }
}
