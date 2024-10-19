namespace FitnessTracker.Forms;

partial class GoalForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        goalFormTitleLbl = new Label();
        caloriesTargetLbl = new Label();
        createGoalBtn = new Button();
        caloriesTargetUpDown = new NumericUpDown();
        goalTitleTxt = new TextBox();
        goalTitleLbl = new Label();
        goalsGridView = new DataGridView();
        Title = new DataGridViewTextBoxColumn();
        CaloriesTarget = new DataGridViewTextBoxColumn();
        Progress = new DataGridViewTextBoxColumn();
        quoteLabelTitle = new Label();
        quoteLbl = new Label();
        ((System.ComponentModel.ISupportInitialize)caloriesTargetUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)goalsGridView).BeginInit();
        SuspendLayout();
        // 
        // goalFormTitleLbl
        // 
        goalFormTitleLbl.AutoSize = true;
        goalFormTitleLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        goalFormTitleLbl.Location = new Point(12, 186);
        goalFormTitleLbl.Name = "goalFormTitleLbl";
        goalFormTitleLbl.Size = new Size(160, 25);
        goalFormTitleLbl.TabIndex = 2;
        goalFormTitleLbl.Text = "Create New Goal";
        // 
        // caloriesTargetLbl
        // 
        caloriesTargetLbl.AutoSize = true;
        caloriesTargetLbl.Location = new Point(210, 233);
        caloriesTargetLbl.Name = "caloriesTargetLbl";
        caloriesTargetLbl.Size = new Size(141, 25);
        caloriesTargetLbl.TabIndex = 3;
        caloriesTargetLbl.Text = "Calories Target:";
        // 
        // createGoalBtn
        // 
        createGoalBtn.Location = new Point(272, 299);
        createGoalBtn.Name = "createGoalBtn";
        createGoalBtn.Size = new Size(121, 40);
        createGoalBtn.TabIndex = 3;
        createGoalBtn.Text = "Create";
        createGoalBtn.UseVisualStyleBackColor = true;
        createGoalBtn.Click += createGoalBtn_Click;
        // 
        // caloriesTargetUpDown
        // 
        caloriesTargetUpDown.DecimalPlaces = 2;
        caloriesTargetUpDown.Location = new Point(210, 261);
        caloriesTargetUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        caloriesTargetUpDown.Name = "caloriesTargetUpDown";
        caloriesTargetUpDown.Size = new Size(183, 32);
        caloriesTargetUpDown.TabIndex = 2;
        // 
        // goalTitleTxt
        // 
        goalTitleTxt.Location = new Point(12, 261);
        goalTitleTxt.Name = "goalTitleTxt";
        goalTitleTxt.PlaceholderText = "Enter goal title";
        goalTitleTxt.Size = new Size(183, 32);
        goalTitleTxt.TabIndex = 1;
        // 
        // goalTitleLbl
        // 
        goalTitleLbl.AutoSize = true;
        goalTitleLbl.Location = new Point(12, 233);
        goalTitleLbl.Name = "goalTitleLbl";
        goalTitleLbl.Size = new Size(96, 25);
        goalTitleLbl.TabIndex = 9;
        goalTitleLbl.Text = "Goal Title:";
        // 
        // goalsGridView
        // 
        goalsGridView.AllowUserToAddRows = false;
        goalsGridView.AllowUserToDeleteRows = false;
        goalsGridView.AllowUserToResizeColumns = false;
        goalsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        goalsGridView.Columns.AddRange(new DataGridViewColumn[] { Title, CaloriesTarget, Progress });
        goalsGridView.Location = new Point(12, 12);
        goalsGridView.Name = "goalsGridView";
        goalsGridView.ReadOnly = true;
        goalsGridView.Size = new Size(575, 150);
        goalsGridView.TabIndex = 10;
        // 
        // Title
        // 
        Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Title.DataPropertyName = "Title";
        Title.HeaderText = "Title";
        Title.Name = "Title";
        Title.ReadOnly = true;
        // 
        // CaloriesTarget
        // 
        CaloriesTarget.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        CaloriesTarget.DataPropertyName = "CaloriesTarget";
        CaloriesTarget.HeaderText = "Calories Target";
        CaloriesTarget.Name = "CaloriesTarget";
        CaloriesTarget.ReadOnly = true;
        CaloriesTarget.Resizable = DataGridViewTriState.True;
        // 
        // Progress
        // 
        Progress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        Progress.DataPropertyName = "Progress";
        Progress.HeaderText = "Progress (%)";
        Progress.Name = "Progress";
        Progress.ReadOnly = true;
        // 
        // quoteLabelTitle
        // 
        quoteLabelTitle.AutoSize = true;
        quoteLabelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Underline);
        quoteLabelTitle.Location = new Point(428, 186);
        quoteLabelTitle.Name = "quoteLabelTitle";
        quoteLabelTitle.Size = new Size(159, 25);
        quoteLabelTitle.TabIndex = 11;
        quoteLabelTitle.Text = "Quote of The Day";
        // 
        // quoteLbl
        // 
        quoteLbl.AutoSize = true;
        quoteLbl.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
        quoteLbl.Location = new Point(428, 224);
        quoteLbl.MaximumSize = new Size(160, 0);
        quoteLbl.Name = "quoteLbl";
        quoteLbl.Size = new Size(0, 20);
        quoteLbl.TabIndex = 12;
        // 
        // GoalForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(599, 373);
        Controls.Add(quoteLbl);
        Controls.Add(quoteLabelTitle);
        Controls.Add(goalsGridView);
        Controls.Add(goalTitleLbl);
        Controls.Add(goalTitleTxt);
        Controls.Add(caloriesTargetUpDown);
        Controls.Add(createGoalBtn);
        Controls.Add(caloriesTargetLbl);
        Controls.Add(goalFormTitleLbl);
        Font = new Font("Segoe UI", 14F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "GoalForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Goals";
        Load += GoalForm_Load;
        ((System.ComponentModel.ISupportInitialize)caloriesTargetUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)goalsGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label goalFormTitleLbl;
    private Label caloriesTargetLbl;
    private Button createGoalBtn;
    private NumericUpDown caloriesTargetUpDown;
    private TextBox goalTitleTxt;
    private Label goalTitleLbl;
    private DataGridView goalsGridView;
    private DataGridViewTextBoxColumn Title;
    private DataGridViewTextBoxColumn CaloriesTarget;
    private DataGridViewTextBoxColumn Progress;
    private Label quoteLabelTitle;
    private Label quoteLbl;
}