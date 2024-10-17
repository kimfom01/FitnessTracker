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

        IPasswordManager passwordManager = new PasswordManager();
        IUserRepository userRepository = new UserRepository(dbContext);
        IAuthenticationService authenticationService = new AuthenticationService(passwordManager, userRepository);

        IInputFormatValidator inputFormatValidator = new InputFormatValidator();
        return new LoginForm(authenticationService, inputFormatValidator);
    }

    public static RegistrationForm CreateRegistrationForm()
    {
        var dbContext = new FitnessContext();

        IPasswordManager passwordManager = new PasswordManager();
        IUserRepository userRepository = new UserRepository(dbContext);

        IInputFormatValidator inputFormatValidator = new InputFormatValidator();
        IAuthenticationService authenticationService = new AuthenticationService(passwordManager, userRepository);

        return new RegistrationForm(authenticationService, inputFormatValidator);
    }

    public static ResetPasswordForm CreateResetPasswordForm(string username)
    {
        var dbContext = new FitnessContext();

        IPasswordManager passwordManager = new PasswordManager();
        IUserRepository userRepository = new UserRepository(dbContext);

        IInputFormatValidator inputFormatValidator = new InputFormatValidator();
        IAuthenticationService authenticationService = new AuthenticationService(passwordManager, userRepository);

        return new ResetPasswordForm(authenticationService, inputFormatValidator, username);
    }
}
