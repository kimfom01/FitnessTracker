using FitnessTracker.DataAccess;
using FitnessTracker.DataAccess.Entities;
using FitnessTracker.DataAccess.Repositories;
using FitnessTracker.Passwords;
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
        _userRepository = new UserRepository(new FitnessContext());
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

            if (_userRepository.CheckIfUserExist(username))
            {
                MessageBox.Show("This username is already taken!");
                return;
            }

            string hashedPassword = _passwordManager.HashPassword(passwordTxt.Text);

            var added = _userRepository.AddUser(ApplicationUser.Create(username, hashedPassword, phoneNumber));
            _userRepository.SaveChanges();

            MessageBox.Show($"Account Registered!\nYou can proceed to login");
            OpenLoginForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured: {ex.Message}");
            return;
        }
    }

    private void loginLbl_Click(object sender, EventArgs e)
    {

        OpenLoginForm();
    }

    private void OpenLoginForm()
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
