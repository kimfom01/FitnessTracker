using FitnessTracker.Database.Passwords;
using FitnessTracker.Database.Repositories;
using FitnessTracker.Models;
using FitnessTracker.Validation;

namespace FitnessTracker;

public partial class RegistrationForm : Form
{
    private readonly IInputFormatValidator _inputFormatValidator;
    private readonly IPasswordManager _passwordManager;
    private readonly IUserRepository _userRepository;

    public RegistrationForm()
    {
        InitializeComponent();

        _inputFormatValidator = new InputFormatValidator();
        _passwordManager = new PasswordManager();
        _userRepository = new UserRepository();
    }

    private void registerBtn_Click(object sender, EventArgs e)
    {
        var validated = ValidateFormInput();

        if (!validated)
        {
            return;
        }

        try
        {
            string username = usernameTxt.Text;

            var phoneNumber = phoneNumberTxt.Text;

            string password = passwordTxt.Text;

            if (_userRepository.CheckIfUserExist(username))
            {
                MessageBox.Show("This username is already taken!");
                return;
            }

            var added = _userRepository.AddUser(new ApplicationUser
            {
                Username = username,
                PhoneNumber = phoneNumber,
                Password = _passwordManager.HashPassword(password)
            });

            MessageBox.Show($"Account Registered!\nYou can proceed to login");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured: {ex.Message}");
            return;
        }
    }

    private void loginLbl_Click(object sender, EventArgs e)
    {

        var loginThread = new Thread(() =>
        {
            Application.Run(new LoginForm());
        });

        loginThread.Start();

        Close();
    }

    private bool ValidateFormInput()
    {
        if (!_inputFormatValidator.ValidateUsername(usernameTxt.Text))
        {
            MessageBox.Show("Invalid username format: Usernames must contain only letters and numbers");
            return false;
        }

        if (!_inputFormatValidator.ValidatePhoneNumber(phoneNumberTxt.Text))
        {
            MessageBox.Show("Invalid phone number format: Example 0972060814");
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
