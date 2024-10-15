using FitnessTracker.Database;
using FitnessTracker.Database.Passwords;
using FitnessTracker.Database.Repositories;
using FitnessTracker.Forms;
using FitnessTracker.Validation;

namespace FitnessTracker;

public partial class LoginForm : Form
{
    private readonly IInputFormatValidator _inputFormatValidator;
    private readonly IPasswordManager _passwordManager;
    private readonly IUserRepository _userRepository;

    private const int MaxLoginAttempts = 3;
    private const int NoAttempts = 0;

    public LoginForm()
    {
        InitializeComponent();

        _inputFormatValidator = new InputFormatValidator();
        _passwordManager = new PasswordManager();
        _userRepository = new UserRepository(new FitnessContext());
    }

    private void loginBtn_Click(object sender, EventArgs e)
    {
        var validated = ValidateFormInput();

        if (!validated)
        {
            return;
        }

        string username = usernameTxt.Text;

        string password = passwordTxt.Text;

        var user = _userRepository.GetUser(username);

        if (user is null)
        {
            MessageBox.Show("Invalid username or password");
            return;
        }

        if (user.IsLocked)
        {
            MessageBox.Show("Your account is locked. Please reset your password!");
            InitiateAccountRecovery(user.Username);
            return;
        }

        if (!_passwordManager.VerifyPassword(password, user.Password))
        {
            if (user.LoginAttempts == NoAttempts)
            {
                user.LockAccount();
                _userRepository.SaveChanges();

                MessageBox.Show("Your account is locked. Please reset your password!");
                InitiateAccountRecovery(user.Username);
                return;
            }

            user.UpdateLoginAttempts();
            _userRepository.SaveChanges();
            MessageBox.Show("Invalid username or password");
            return;
        }

        if (user.LoginAttempts < MaxLoginAttempts)
        {
            user.ResetLoginAttempts();
            _userRepository.SaveChanges();
        }

        MessageBox.Show("User successfully logged in!");
    }

    private void registerLbl_Click(object sender, EventArgs e)
    {
        var registrationThread = new Thread(() =>
        {
            Application.Run(new RegistrationForm());
        });

        registrationThread.Start();

        Close();
    }

    private void InitiateAccountRecovery(string username)
    {
        var resetPasswordThread = new Thread(() =>
        {
            Application.Run(new ResetPasswordForm(username));
        });

        resetPasswordThread.Start();

        Close();
    }

    private bool ValidateFormInput()
    {
        if (!_inputFormatValidator.ValidateUsername(usernameTxt.Text))
        {
            MessageBox.Show("Invalid username format: Usernames must contain only letters and numbers");
            return false;
        }

        if (!_inputFormatValidator.ValidatePasswordLength(passwordTxt.Text))
        {
            MessageBox.Show("Invalid password length: Passwords must not exceed 12 characters");
            return false;
        }

        if (!_inputFormatValidator.ValidatePasswordFormat(passwordTxt.Text))
        {
            MessageBox.Show("Invalid password format: Passwords must contain at least 1 uppercase and 1 lower case character");
            return false;
        }

        return true;
    }
}
