using FitnessTracker.CoreLogic.Exceptions;
using FitnessTracker.CoreLogic.Services;
using FitnessTracker.CoreLogic.Validation;

namespace FitnessTracker.Forms.Activities;

public partial class LogCyclingForm : Form
{
    private readonly IInputFormatValidator _formatValidator;
    private readonly IActivitiesService _activitiesService;
    private readonly int _userId;

    public LogCyclingForm(IInputFormatValidator formatValidator, IActivitiesService activitiesService, int userId)
    {
        _formatValidator = formatValidator;
        _activitiesService = activitiesService;
        _userId = userId;
        InitializeComponent();
    }

    private async void saveLogCyclingBtn_Click(object sender, EventArgs e)
    {
        if (!ValidateFormInput())
        {
            return;
        }

        var distance = Convert.ToDouble(distanceTxt.Text);
        var timeTaken = Convert.ToInt32(timeTakenTxt.Text);
        var heartRate = Convert.ToDouble(heartRateTxt.Text);

        try
        {
            var created = await _activitiesService.LogCycling(_userId, distance, timeTaken, heartRate);
            var calories = Math.Round(created.Calories, 2);
            
            MessageBox.Show($"Cycling logged! Calories = {calories}");
            Close();
        }
        catch (NotFoundException ex)
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

    private bool ValidateFormInput()
    {
        if (!_formatValidator.ValidateNumberDouble(distanceTxt.Text))
        {
            MessageBox.Show("Please enter a valid distance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!_formatValidator.ValidateNumberInt(timeTakenTxt.Text))
        {
            MessageBox.Show("Please enter a valid time!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        if (!_formatValidator.ValidateNumberDouble(heartRateTxt.Text))
        {
            MessageBox.Show("Please enter a valid distance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }
}