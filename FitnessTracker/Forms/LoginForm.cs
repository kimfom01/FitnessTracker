using FitnessTracker.Database.Passwords;
using FitnessTracker.Database.Repositories;
using FitnessTracker.Validation;

namespace FitnessTracker;

public partial class LoginForm : Form
{
    private readonly IInputFormatValidator _inputFormatValidator;
    private readonly IPasswordManager _passwordManager;
    private readonly IUserRepository _userRepository;

    public LoginForm()
    {
        InitializeComponent();

        _inputFormatValidator = new InputFormatValidator();
        _passwordManager = new PasswordManager();
        _userRepository = new UserRepository();
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

        if (!_passwordManager.VerifyPassword(password, user.Password))
        {
            MessageBox.Show("Invalid username or password");
            return;
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
