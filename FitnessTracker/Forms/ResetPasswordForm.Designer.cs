namespace FitnessTracker.Forms;

partial class ResetPasswordForm
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
        passwordTxt = new TextBox();
        passwordLbl = new Label();
        phoneNumberLbl = new Label();
        phoneNumberTxt = new TextBox();
        resetTitleLbl = new Label();
        resetBtn = new Button();
        SuspendLayout();
        // 
        // passwordTxt
        // 
        passwordTxt.Location = new Point(78, 256);
        passwordTxt.Name = "passwordTxt";
        passwordTxt.PasswordChar = '*';
        passwordTxt.PlaceholderText = "Enter password";
        passwordTxt.Size = new Size(489, 32);
        passwordTxt.TabIndex = 2;
        // 
        // passwordLbl
        // 
        passwordLbl.AutoSize = true;
        passwordLbl.Location = new Point(78, 211);
        passwordLbl.Name = "passwordLbl";
        passwordLbl.Size = new Size(95, 25);
        passwordLbl.TabIndex = 11;
        passwordLbl.Text = "Password:";
        // 
        // phoneNumberLbl
        // 
        phoneNumberLbl.AutoSize = true;
        phoneNumberLbl.Location = new Point(78, 100);
        phoneNumberLbl.Name = "phoneNumberLbl";
        phoneNumberLbl.Size = new Size(140, 25);
        phoneNumberLbl.TabIndex = 9;
        phoneNumberLbl.Text = "Phone Number";
        // 
        // phoneNumberTxt
        // 
        phoneNumberTxt.Location = new Point(78, 137);
        phoneNumberTxt.Name = "phoneNumberTxt";
        phoneNumberTxt.PlaceholderText = "Enter phone number";
        phoneNumberTxt.Size = new Size(489, 32);
        phoneNumberTxt.TabIndex = 1;
        // 
        // resetTitleLbl
        // 
        resetTitleLbl.AutoSize = true;
        resetTitleLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        resetTitleLbl.Location = new Point(163, 9);
        resetTitleLbl.Name = "resetTitleLbl";
        resetTitleLbl.Size = new Size(300, 40);
        resetTitleLbl.TabIndex = 7;
        resetTitleLbl.Text = "Reset Your Password";
        resetTitleLbl.TextAlign = ContentAlignment.TopCenter;
        // 
        // resetBtn
        // 
        resetBtn.Location = new Point(446, 308);
        resetBtn.Name = "resetBtn";
        resetBtn.Size = new Size(121, 40);
        resetBtn.TabIndex = 3;
        resetBtn.Text = "Reset";
        resetBtn.UseVisualStyleBackColor = true;
        resetBtn.Click += resetBtn_Click;
        // 
        // ResetPasswordForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(646, 450);
        Controls.Add(passwordTxt);
        Controls.Add(passwordLbl);
        Controls.Add(phoneNumberLbl);
        Controls.Add(phoneNumberTxt);
        Controls.Add(resetTitleLbl);
        Controls.Add(resetBtn);
        Font = new Font("Segoe UI", 14F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "ResetPasswordForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Reset Password";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TextBox passwordTxt;
    private Label passwordLbl;
    private Label phoneNumberLbl;
    private TextBox phoneNumberTxt;
    private Label resetTitleLbl;
    private Button resetBtn;
}