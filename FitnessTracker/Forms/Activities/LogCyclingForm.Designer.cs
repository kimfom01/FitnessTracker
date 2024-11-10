namespace FitnessTracker.Forms.Activities;

partial class LogCyclingForm
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
        passwordLbl = new Label();
        distanceLbl = new Label();
        loginTitleLbl = new Label();
        saveLogCyclingBtn = new Button();
        heartRateLbl = new Label();
        distanceTxt = new NumericUpDown();
        timeTakenTxt = new NumericUpDown();
        heartRateTxt = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)distanceTxt).BeginInit();
        ((System.ComponentModel.ISupportInitialize)timeTakenTxt).BeginInit();
        ((System.ComponentModel.ISupportInitialize)heartRateTxt).BeginInit();
        SuspendLayout();
        // 
        // passwordLbl
        // 
        passwordLbl.AutoSize = true;
        passwordLbl.Location = new Point(19, 227);
        passwordLbl.Margin = new Padding(5, 0, 5, 0);
        passwordLbl.Name = "passwordLbl";
        passwordLbl.Size = new Size(194, 25);
        passwordLbl.TabIndex = 11;
        passwordLbl.Text = "Time Taken (minutes):";
        // 
        // distanceLbl
        // 
        distanceLbl.AutoSize = true;
        distanceLbl.Location = new Point(19, 103);
        distanceLbl.Margin = new Padding(5, 0, 5, 0);
        distanceLbl.Name = "distanceLbl";
        distanceLbl.Size = new Size(162, 25);
        distanceLbl.TabIndex = 9;
        distanceLbl.Text = "Distance (meters):";
        // 
        // loginTitleLbl
        // 
        loginTitleLbl.AutoSize = true;
        loginTitleLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)0));
        loginTitleLbl.Location = new Point(105, 15);
        loginTitleLbl.Margin = new Padding(5, 0, 5, 0);
        loginTitleLbl.Name = "loginTitleLbl";
        loginTitleLbl.Size = new Size(176, 40);
        loginTitleLbl.TabIndex = 7;
        loginTitleLbl.Text = "Log Cycling";
        loginTitleLbl.TextAlign = ContentAlignment.TopCenter;
        // 
        // saveLogCyclingBtn
        // 
        saveLogCyclingBtn.Location = new Point(277, 470);
        saveLogCyclingBtn.Margin = new Padding(5, 5, 5, 5);
        saveLogCyclingBtn.Name = "saveLogCyclingBtn";
        saveLogCyclingBtn.Size = new Size(190, 67);
        saveLogCyclingBtn.TabIndex = 10;
        saveLogCyclingBtn.Text = "Save";
        saveLogCyclingBtn.UseVisualStyleBackColor = true;
        saveLogCyclingBtn.Click += saveLogCyclingBtn_Click;
        // 
        // heartRateLbl
        // 
        heartRateLbl.AutoSize = true;
        heartRateLbl.Location = new Point(19, 360);
        heartRateLbl.Margin = new Padding(5, 0, 5, 0);
        heartRateLbl.Name = "heartRateLbl";
        heartRateLbl.Size = new Size(263, 25);
        heartRateLbl.TabIndex = 14;
        heartRateLbl.Text = "Heart Rate (beats per minute):";
        // 
        // distanceTxt
        // 
        distanceTxt.DecimalPlaces = 2;
        distanceTxt.Location = new Point(19, 150);
        distanceTxt.Margin = new Padding(5, 5, 5, 5);
        distanceTxt.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        distanceTxt.Name = "distanceTxt";
        distanceTxt.Size = new Size(448, 32);
        distanceTxt.TabIndex = 15;
        // 
        // timeTakenTxt
        // 
        timeTakenTxt.Location = new Point(19, 273);
        timeTakenTxt.Margin = new Padding(5, 5, 5, 5);
        timeTakenTxt.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        timeTakenTxt.Name = "timeTakenTxt";
        timeTakenTxt.Size = new Size(448, 32);
        timeTakenTxt.TabIndex = 16;
        // 
        // heartRateTxt
        // 
        heartRateTxt.DecimalPlaces = 2;
        heartRateTxt.Location = new Point(19, 407);
        heartRateTxt.Margin = new Padding(5, 5, 5, 5);
        heartRateTxt.Name = "heartRateTxt";
        heartRateTxt.Size = new Size(448, 32);
        heartRateTxt.TabIndex = 17;
        // 
        // LogCyclingForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(497, 568);
        Controls.Add(heartRateTxt);
        Controls.Add(timeTakenTxt);
        Controls.Add(distanceTxt);
        Controls.Add(heartRateLbl);
        Controls.Add(passwordLbl);
        Controls.Add(distanceLbl);
        Controls.Add(loginTitleLbl);
        Controls.Add(saveLogCyclingBtn);
        Font = new Font("Segoe UI", 14F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Log Cycling";
        ((System.ComponentModel.ISupportInitialize)distanceTxt).EndInit();
        ((System.ComponentModel.ISupportInitialize)timeTakenTxt).EndInit();
        ((System.ComponentModel.ISupportInitialize)heartRateTxt).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label passwordLbl;
    private Label distanceLbl;
    private Label loginTitleLbl;
    private Button saveLogCyclingBtn;
    private Label heartRateLbl;
    private NumericUpDown distanceTxt;
    private NumericUpDown timeTakenTxt;
    private NumericUpDown heartRateTxt;
}