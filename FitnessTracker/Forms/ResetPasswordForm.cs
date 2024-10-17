using FitnessTracker.CoreLogic.Exceptions;
using FitnessTracker.CoreLogic.Services;
using FitnessTracker.CoreLogic.Validation;

namespace FitnessTracker.Forms;

public partial class ResetPasswordForm : Form
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IInputFormatValidator _inputFormatValidator;
    private readonly string _username;

    public ResetPasswordForm(IAuthenticationService authenticationService, IInputFormatValidator inputFormatValidator, string username)
    {
        InitializeComponent();
        _authenticationService = authenticationService;
        _inputFormatValidator = inputFormatValidator;
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
        var password = passwordTxt.Text;

        try
        {
            _authenticationService.ResetPassword(_username, phoneNumber, password);

            MessageBox.Show("Successfully updated your password!\nYou can now login and continue using your account");
            OpenLoginForm();
        }
        catch (NotFoundException ex)
        {
            MessageBox.Show(ex.Message);
            Close();
            return;
        }
        catch(InvalidPhoneNumberException ex)
        {
            MessageBox.Show(ex.Message);
            return;
        }
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
            var loginForm = FormFactory.CreateLoginForm();

            Application.Run(loginForm);
        });

        loginThread.Start();

        Close();
    }
}
