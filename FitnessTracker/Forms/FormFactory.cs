using FitnessTracker.DataAccess.Repositories;
using FitnessTracker.DataAccess;
using FitnessTracker.Passwords;
using FitnessTracker.Validation;

namespace FitnessTracker.Forms;

public static class FormFactory
{
    public static LoginForm CreateLoginForm()
    {
        var dbContext = new FitnessContext();

        var _inputFormatValidator = new InputFormatValidator();
        var _passwordManager = new PasswordManager();
        var _userRepository = new UserRepository(dbContext);

        return new LoginForm(_inputFormatValidator, _passwordManager, _userRepository);
    }

    public static RegistrationForm CreateRegistrationForm()
    {
        var dbContext = new FitnessContext();

        var _inputFormatValidator = new InputFormatValidator();
        var _passwordManager = new PasswordManager();
        var _userRepository = new UserRepository(dbContext);

        return new RegistrationForm(_inputFormatValidator, _passwordManager, _userRepository);
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
