using FitnessTracker.Database;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var dbContext = new FitnessContext();
        dbContext.Database.Migrate();
        Application.Run(new LoginForm());
    }
}