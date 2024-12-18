using FitnessTracker.CoreLogic.Exceptions;
using FitnessTracker.CoreLogic.Services;
using FitnessTracker.CoreLogic.Validation;

namespace FitnessTracker.Forms;

public partial class LoginForm : Form
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IInputFormatValidator _inputFormatValidator;

    public LoginForm(IAuthenticationService authenticationService, IInputFormatValidator inputFormatValidator)
    {
        InitializeComponent();

        _authenticationService = authenticationService;
        _inputFormatValidator = inputFormatValidator;
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

        try
        {
            var userId = _authenticationService.LoginUser(username, password);

            MessageBox.Show("User successfully logged in!");

            LaunchGoalForm(userId);
        }
        catch (NotFoundException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (AccountLockedException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            InitiateAccountRecovery(username);
            return;
        }
        catch (InvalidPasswordExeption ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void registerLbl_Click(object sender, EventArgs e)
    {
        var registrationThread = new Thread(() =>
        {
            var registrationForm = FormFactory.CreateRegistrationForm();

            Application.Run(registrationForm);
        });

        registrationThread.Start();

        Close();
    }

    private void InitiateAccountRecovery(string username)
    {
        var resetPasswordThread = new Thread(() =>
        {
            var resetPasswordForm = FormFactory.CreateResetPasswordForm(username);

            Application.Run(resetPasswordForm);
        });

        resetPasswordThread.Start();

        Close();
    }

    private void LaunchGoalForm(int userId)
    {
        var goalFormThread = new Thread(() =>
        {
            var goalForm = FormFactory.CreateGoalForm(userId);

            Application.Run(goalForm);
        });

        goalFormThread.Start();

        Close();
    }

    private bool ValidateFormInput()
    {
        if (!_inputFormatValidator.ValidateUsername(usernameTxt.Text))
        {
            MessageBox.Show("Invalid username format: Usernames must contain only letters and numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!_inputFormatValidator.ValidatePasswordLength(passwordTxt.Text))
        {
            MessageBox.Show("Invalid password length: Passwords must not exceed 12 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!_inputFormatValidator.ValidatePasswordFormat(passwordTxt.Text))
        {
            MessageBox.Show("Invalid password format: Passwords must contain at least 1 uppercase and 1 lower case character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
}
