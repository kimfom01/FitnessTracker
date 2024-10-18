using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitnessTracker.Database.Migrations;

/// <inheritdoc />
public partial class AddGoalAndInitialActivities : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "Goals",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                CaloriesTarget = table.Column<double>(type: "REAL", nullable: false),
                Progress = table.Column<double>(type: "REAL", nullable: false),
                CreatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Goals", x => x.Id);
                table.ForeignKey(
                    name: "FK_Goals_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Swimmings",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                GoalId = table.Column<int>(type: "INTEGER", nullable: false),
                Laps = table.Column<int>(type: "INTEGER", nullable: false),
                TimeTaken = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                HeartRate = table.Column<double>(type: "REAL", nullable: false),
                Calories = table.Column<double>(type: "REAL", nullable: false),
                CreatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Swimmings", x => x.Id);
                table.ForeignKey(
                    name: "FK_Swimmings_Goals_GoalId",
                    column: x => x.GoalId,
                    principalTable: "Goals",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Swimmings_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "Walkings",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                GoalId = table.Column<int>(type: "INTEGER", nullable: false),
                Steps = table.Column<int>(type: "INTEGER", nullable: false),
                Distance = table.Column<double>(type: "REAL", nullable: false),
                TimeTaken = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                Calories = table.Column<double>(type: "REAL", nullable: false),
                CreatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false),
                UpdatedAtUtc = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Walkings", x => x.Id);
                table.ForeignKey(
                    name: "FK_Walkings_Goals_GoalId",
                    column: x => x.GoalId,
                    principalTable: "Goals",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_Walkings_Users_UserId",
                    column: x => x.UserId,
                    principalTable: "Users",
                    principalColumn: "Id",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_Goals_UserId",
            table: "Goals",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_Swimmings_GoalId",
            table: "Swimmings",
            column: "GoalId");

        migrationBuilder.CreateIndex(
            name: "IX_Swimmings_UserId",
            table: "Swimmings",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_Walkings_GoalId",
            table: "Walkings",
            column: "GoalId");

        migrationBuilder.CreateIndex(
            name: "IX_Walkings_UserId",
            table: "Walkings",
            column: "UserId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Swimmings");

        migrationBuilder.DropTable(
            name: "Walkings");

        migrationBuilder.DropTable(
            name: "Goals");
    }
}
