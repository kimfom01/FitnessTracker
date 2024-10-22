﻿namespace FitnessTracker.Forms;

partial class FitnessTrackerForm
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
        fitnessTrackerTabControl = new TabControl();
        activitiestab = new TabPage();
        label1 = new Label();
        goalsTab = new TabPage();
        profileTab = new TabPage();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)caloriesTargetUpDown).BeginInit();
        ((System.ComponentModel.ISupportInitialize)goalsGridView).BeginInit();
        fitnessTrackerTabControl.SuspendLayout();
        activitiestab.SuspendLayout();
        goalsTab.SuspendLayout();
        profileTab.SuspendLayout();
        SuspendLayout();
        // 
        // goalFormTitleLbl
        // 
        goalFormTitleLbl.AutoSize = true;
        goalFormTitleLbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        goalFormTitleLbl.Location = new Point(16, 284);
        goalFormTitleLbl.Name = "goalFormTitleLbl";
        goalFormTitleLbl.Size = new Size(160, 25);
        goalFormTitleLbl.TabIndex = 2;
        goalFormTitleLbl.Text = "Create New Goal";
        // 
        // caloriesTargetLbl
        // 
        caloriesTargetLbl.AutoSize = true;
        caloriesTargetLbl.Location = new Point(214, 331);
        caloriesTargetLbl.Name = "caloriesTargetLbl";
        caloriesTargetLbl.Size = new Size(141, 25);
        caloriesTargetLbl.TabIndex = 3;
        caloriesTargetLbl.Text = "Calories Target:";
        // 
        // createGoalBtn
        // 
        createGoalBtn.Location = new Point(276, 397);
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
        caloriesTargetUpDown.Location = new Point(214, 359);
        caloriesTargetUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
        caloriesTargetUpDown.Name = "caloriesTargetUpDown";
        caloriesTargetUpDown.Size = new Size(183, 32);
        caloriesTargetUpDown.TabIndex = 2;
        // 
        // goalTitleTxt
        // 
        goalTitleTxt.Location = new Point(16, 359);
        goalTitleTxt.Name = "goalTitleTxt";
        goalTitleTxt.PlaceholderText = "Enter goal title";
        goalTitleTxt.Size = new Size(183, 32);
        goalTitleTxt.TabIndex = 1;
        // 
        // goalTitleLbl
        // 
        goalTitleLbl.AutoSize = true;
        goalTitleLbl.Location = new Point(16, 331);
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
        goalsGridView.Location = new Point(16, 22);
        goalsGridView.Name = "goalsGridView";
        goalsGridView.ReadOnly = true;
        goalsGridView.Size = new Size(575, 234);
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
        quoteLabelTitle.Location = new Point(432, 284);
        quoteLabelTitle.Name = "quoteLabelTitle";
        quoteLabelTitle.Size = new Size(159, 25);
        quoteLabelTitle.TabIndex = 11;
        quoteLabelTitle.Text = "Quote of The Day";
        // 
        // quoteLbl
        // 
        quoteLbl.AutoSize = true;
        quoteLbl.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
        quoteLbl.Location = new Point(432, 322);
        quoteLbl.MaximumSize = new Size(160, 0);
        quoteLbl.Name = "quoteLbl";
        quoteLbl.Size = new Size(0, 20);
        quoteLbl.TabIndex = 12;
        // 
        // fitnessTrackerTabControl
        // 
        fitnessTrackerTabControl.Controls.Add(activitiestab);
        fitnessTrackerTabControl.Controls.Add(goalsTab);
        fitnessTrackerTabControl.Controls.Add(profileTab);
        fitnessTrackerTabControl.Location = new Point(12, 12);
        fitnessTrackerTabControl.Name = "fitnessTrackerTabControl";
        fitnessTrackerTabControl.SelectedIndex = 0;
        fitnessTrackerTabControl.Size = new Size(1286, 698);
        fitnessTrackerTabControl.TabIndex = 13;
        // 
        // activitiestab
        // 
        activitiestab.Controls.Add(label1);
        activitiestab.Location = new Point(4, 34);
        activitiestab.Name = "activitiestab";
        activitiestab.Padding = new Padding(3);
        activitiestab.Size = new Size(1278, 660);
        activitiestab.TabIndex = 1;
        activitiestab.Text = "Activities";
        activitiestab.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
        label1.Location = new Point(455, 309);
        label1.Name = "label1";
        label1.Size = new Size(376, 25);
        label1.TabIndex = 0;
        label1.Text = "Still In Development Please Check Back Later";
        // 
        // goalsTab
        // 
        goalsTab.Controls.Add(goalsGridView);
        goalsTab.Controls.Add(quoteLbl);
        goalsTab.Controls.Add(goalFormTitleLbl);
        goalsTab.Controls.Add(quoteLabelTitle);
        goalsTab.Controls.Add(caloriesTargetLbl);
        goalsTab.Controls.Add(createGoalBtn);
        goalsTab.Controls.Add(goalTitleLbl);
        goalsTab.Controls.Add(caloriesTargetUpDown);
        goalsTab.Controls.Add(goalTitleTxt);
        goalsTab.Location = new Point(4, 34);
        goalsTab.Name = "goalsTab";
        goalsTab.Padding = new Padding(3);
        goalsTab.Size = new Size(1278, 660);
        goalsTab.TabIndex = 0;
        goalsTab.Text = "Goals";
        goalsTab.UseVisualStyleBackColor = true;
        goalsTab.Enter += goalsTab_Enter;
        // 
        // profileTab
        // 
        profileTab.Controls.Add(label2);
        profileTab.Location = new Point(4, 34);
        profileTab.Name = "profileTab";
        profileTab.Padding = new Padding(3);
        profileTab.Size = new Size(1278, 660);
        profileTab.TabIndex = 2;
        profileTab.Text = "Profile";
        profileTab.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
        label2.Location = new Point(452, 297);
        label2.Name = "label2";
        label2.Size = new Size(376, 25);
        label2.TabIndex = 0;
        label2.Text = "Still In Development Please Check Back Later";
        // 
        // FitnessTrackerForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1310, 722);
        Controls.Add(fitnessTrackerTabControl);
        Font = new Font("Segoe UI", 14F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "FitnessTrackerForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Fitness Tracker";
        ((System.ComponentModel.ISupportInitialize)caloriesTargetUpDown).EndInit();
        ((System.ComponentModel.ISupportInitialize)goalsGridView).EndInit();
        fitnessTrackerTabControl.ResumeLayout(false);
        activitiestab.ResumeLayout(false);
        activitiestab.PerformLayout();
        goalsTab.ResumeLayout(false);
        goalsTab.PerformLayout();
        profileTab.ResumeLayout(false);
        profileTab.PerformLayout();
        ResumeLayout(false);
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
    private TabControl fitnessTrackerTabControl;
    private TabPage goalsTab;
    private TabPage activitiestab;
    private TabPage profileTab;
    private Label label1;
    private Label label2;
}