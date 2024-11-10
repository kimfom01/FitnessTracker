using FitnessTracker.CoreLogic.Exceptions;
using FitnessTracker.CoreLogic.Services;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace FitnessTracker.Forms;

public partial class FitnessTrackerForm : Form
{
    private readonly IGoalService _goalService;
    private readonly int _userId;

    public FitnessTrackerForm(IGoalService goalService, int userId)
    {
        InitializeComponent();

        _goalService = goalService;
        _userId = userId;
    }

    private async void createGoalBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(goalTitleTxt.Text))
        {
            MessageBox.Show("Please enter a title!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var title = goalTitleTxt.Text;
        var target = Convert.ToDouble(caloriesTargetUpDown.Value);

        try
        {
            var goal = await _goalService.CreateNew(_userId, title, target);
            MessageBox.Show($"Goal: {goal.Title} successfully created");
        }
        catch (DuplicateException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        await LoadGoals();
        ResetCreateGoalForm();
    }

    private async Task LoadGoals()
    {
        var goals = await _goalService.GetAllGoals(_userId);

        goalsGridView.AutoGenerateColumns = false;
        goalsGridView.DataSource = goals;
    }

    private void ResetCreateGoalForm()
    {
        goalTitleTxt.Text = string.Empty;
        caloriesTargetUpDown.Value = 0.00M;
    }

    private async Task LoadQuote()
    {
        using var httpClient = new HttpClient();

        var randomId = (new Random()).Next(101);

        var quoteResponse = await httpClient.GetFromJsonAsync<QuoteObject>($"https://dummyjson.com/quotes/{randomId}");

        if (quoteResponse is null)
        {
            return;
        }

        quoteLbl.Text = $"{quoteResponse.Quote}\n-{quoteResponse.Author}";
    }

    private async void goalsTab_Enter(object sender, EventArgs e)
    {
        await LoadGoals();
        await LoadQuote();
    }

    private void activitiesTab_Enter(object sender, EventArgs e)
    {
    }

    private void logCyclingBtn_Click(object sender, EventArgs e)
    {
        var logCyclingForm = FormFactory.CreateLogCyclingForm(_userId);

        logCyclingForm.ShowDialog();
    }
}

record QuoteObject(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("quote")] string Quote,
    [property: JsonPropertyName("author")] string Author
);