namespace FitnessTracker;

partial class RegistrationForm
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
        loginLbl = new LinkLabel();
        passwordTxt = new TextBox();
        passwordLbl = new Label();
        usernameLbl = new Label();
        usernameTxt = new TextBox();
        registrationTitleLbl = new Label();
        registerBtn = new Button();
        phoneNumberLbl = new Label();
        phoneNumberTxt = new TextBox();
        SuspendLayout();
        // 
        // loginLbl
        // 
        loginLbl.AutoSize = true;
        loginLbl.Font = new Font("Segoe UI", 10F);
        loginLbl.Location = new Point(525, 398);
        loginLbl.Name = "loginLbl";
        loginLbl.Size = new Size(43, 19);
        loginLbl.TabIndex = 12;
        loginLbl.TabStop = true;
        loginLbl.Text = "Login";
        loginLbl.Click += loginLbl_Click;
        // 
        // passwordTxt
        // 
        passwordTxt.Location = new Point(79, 303);
        passwordTxt.Name = "passwordTxt";
        passwordTxt.PasswordChar = '*';
        passwordTxt.PlaceholderText = "Enter password";
        passwordTxt.Size = new Size(489, 32);
        passwordTxt.TabIndex = 3;
        // 
        // passwordLbl
        // 
        passwordLbl.AutoSize = true;
        passwordLbl.Location = new Point(79, 258);
        passwordLbl.Name = "passwordLbl";
        passwordLbl.Size = new Size(95, 25);
        passwordLbl.TabIndex = 11;
        passwordLbl.Text = "Password:";
        // 
        // usernameLbl
        // 
        usernameLbl.AutoSize = true;
        usernameLbl.Location = new Point(79, 84);
        usernameLbl.Name = "usernameLbl";
        usernameLbl.Size = new Size(101, 25);
        usernameLbl.TabIndex = 9;
        usernameLbl.Text = "Username:";
        // 
        // usernameTxt
        // 
        usernameTxt.Location = new Point(79, 121);
        usernameTxt.Name = "usernameTxt";
        usernameTxt.PlaceholderText = "Enter username";
        usernameTxt.Size = new Size(489, 32);
        usernameTxt.TabIndex = 1;
        // 
        // registrationTitleLbl
        // 
        registrationTitleLbl.AutoSize = true;
        registrationTitleLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        registrationTitleLbl.Location = new Point(132, 9);
        registrationTitleLbl.Name = "registrationTitleLbl";
        registrationTitleLbl.Size = new Size(395, 40);
        registrationTitleLbl.TabIndex = 7;
        registrationTitleLbl.Text = "Welcome To Fitness Tracker";
        registrationTitleLbl.TextAlign = ContentAlignment.TopCenter;
        // 
        // registerBtn
        // 
        registerBtn.Location = new Point(447, 355);
        registerBtn.Name = "registerBtn";
        registerBtn.Size = new Size(121, 40);
        registerBtn.TabIndex = 4;
        registerBtn.Text = "Register";
        registerBtn.UseVisualStyleBackColor = true;
        registerBtn.Click += registerBtn_Click;
        // 
        // phoneNumberLbl
        // 
        phoneNumberLbl.AutoSize = true;
        phoneNumberLbl.Location = new Point(79, 172);
        phoneNumberLbl.Name = "phoneNumberLbl";
        phoneNumberLbl.Size = new Size(140, 25);
        phoneNumberLbl.TabIndex = 14;
        phoneNumberLbl.Text = "Phone Number";
        // 
        // phoneNumberTxt
        // 
        phoneNumberTxt.Location = new Point(79, 209);
        phoneNumberTxt.Name = "phoneNumberTxt";
        phoneNumberTxt.PlaceholderText = "Enter phone number e.g. 0972060814";
        phoneNumberTxt.Size = new Size(489, 32);
        phoneNumberTxt.TabIndex = 2;
        // 
        // RegistrationForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(646, 450);
        Controls.Add(phoneNumberLbl);
        Controls.Add(phoneNumberTxt);
        Controls.Add(loginLbl);
        Controls.Add(passwordTxt);
        Controls.Add(passwordLbl);
        Controls.Add(usernameLbl);
        Controls.Add(usernameTxt);
        Controls.Add(registrationTitleLbl);
        Controls.Add(registerBtn);
        Font = new Font("Segoe UI", 14F);
        Margin = new Padding(5);
        Name = "RegistrationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Registration Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private LinkLabel loginLbl;
    private TextBox passwordTxt;
    private Label passwordLbl;
    private Label usernameLbl;
    private TextBox usernameTxt;
    private Label registrationTitleLbl;
    private Button registerBtn;
    private Label phoneNumberLbl;
    private TextBox phoneNumberTxt;
}