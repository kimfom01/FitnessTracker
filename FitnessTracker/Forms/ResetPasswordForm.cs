using FitnessTracker.Database;
using FitnessTracker.Database.Passwords;
using FitnessTracker.Database.Repositories;
using FitnessTracker.Validation;

namespace FitnessTracker.Forms;

public partial class ResetPasswordForm : Form
{
    private readonly IInputFormatValidator _inputFormatValidator;
    private readonly IPasswordManager _passwordManager;
    private readonly IUserRepository _userRepository;
    private readonly string _username;

    public ResetPasswordForm(string username)
    {
        InitializeComponent();
        
        _inputFormatValidator = new InputFormatValidator();
        _passwordManager = new PasswordManager();
        _userRepository = new UserRepository(new FitnessContext());
        _username = username;
    }

    private void resetBtn_Click(object sender, EventArgs e)
    {
        var validated = ValidateFormInput();

        if (!validated)
        {
            return;
        }

        var phoneNumber = phoneNumberTxt.Text;
        var password = _passwordManager.HashPassword(passwordTxt.Text);

        var user = _userRepository.GetUser(_username);

        if (user is null)
        {
            MessageBox.Show("Error! Something is really really wrong... this should not be possible");
            Close();
            return;
        }

        bool phoneNumberExists = _userRepository.CheckIfPhoneNumberExists(_username, phoneNumber);

        if (!phoneNumberExists)
        {
            MessageBox.Show("Error! Phone number is wrong.\nPlease enter your phone number or create a new account");
            return;
        }

        user.UpdatePassword(password);
        user.UnLockAccount();
        _userRepository.SaveChanges();
        MessageBox.Show("Successfully updated your password!\nYou can now login and continue using your account");
        OpenLoginForm();
    }

    private bool ValidateFormInput()
    {
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

    private void OpenLoginForm()
    {
        var loginThread = new Thread(() =>
        {
            Application.Run(new LoginForm());
        });

        loginThread.Start();

        Close();
    }
}
