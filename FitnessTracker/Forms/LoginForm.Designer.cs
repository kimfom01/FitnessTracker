namespace FitnessTracker;

partial class LoginForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        loginBtn = new Button();
        loginTitleLbl = new Label();
        usernameTxt = new TextBox();
        usernameLbl = new Label();
        passwordLbl = new Label();
        passwordTxt = new TextBox();
        registerLbl = new LinkLabel();
        SuspendLayout();
        // 
        // loginBtn
        // 
        loginBtn.Location = new Point(442, 322);
        loginBtn.Name = "loginBtn";
        loginBtn.Size = new Size(121, 40);
        loginBtn.TabIndex = 3;
        loginBtn.Text = "Login";
        loginBtn.UseVisualStyleBackColor = true;
        loginBtn.Click += loginBtn_Click;
        // 
        // loginTitleLbl
        // 
        loginTitleLbl.AutoSize = true;
        loginTitleLbl.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        loginTitleLbl.Location = new Point(145, 9);
        loginTitleLbl.Name = "loginTitleLbl";
        loginTitleLbl.Size = new Size(345, 40);
        loginTitleLbl.TabIndex = 1;
        loginTitleLbl.Text = "Login To Fitness Tracker";
        loginTitleLbl.TextAlign = ContentAlignment.TopCenter;
        // 
        // usernameTxt
        // 
        usernameTxt.Location = new Point(74, 151);
        usernameTxt.Name = "usernameTxt";
        usernameTxt.PlaceholderText = "Enter username";
        usernameTxt.Size = new Size(489, 32);
        usernameTxt.TabIndex = 1;
        // 
        // usernameLbl
        // 
        usernameLbl.AutoSize = true;
        usernameLbl.Location = new Point(74, 114);
        usernameLbl.Name = "usernameLbl";
        usernameLbl.Size = new Size(101, 25);
        usernameLbl.TabIndex = 3;
        usernameLbl.Text = "Username:";
        // 
        // passwordLbl
        // 
        passwordLbl.AutoSize = true;
        passwordLbl.Location = new Point(74, 225);
        passwordLbl.Name = "passwordLbl";
        passwordLbl.Size = new Size(95, 25);
        passwordLbl.TabIndex = 4;
        passwordLbl.Text = "Password:";
        // 
        // passwordTxt
        // 
        passwordTxt.Location = new Point(74, 270);
        passwordTxt.Name = "passwordTxt";
        passwordTxt.PasswordChar = '*';
        passwordTxt.PlaceholderText = "Enter password";
        passwordTxt.Size = new Size(489, 32);
        passwordTxt.TabIndex = 2;
        // 
        // registerLbl
        // 
        registerLbl.AutoSize = true;
        registerLbl.Font = new Font("Segoe UI", 10F);
        registerLbl.Location = new Point(505, 365);
        registerLbl.Name = "registerLbl";
        registerLbl.Size = new Size(58, 19);
        registerLbl.TabIndex = 5;
        registerLbl.TabStop = true;
        registerLbl.Text = "Register";
        registerLbl.Click += registerLbl_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(11F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(646, 450);
        Controls.Add(registerLbl);
        Controls.Add(passwordTxt);
        Controls.Add(passwordLbl);
        Controls.Add(usernameLbl);
        Controls.Add(usernameTxt);
        Controls.Add(loginTitleLbl);
        Controls.Add(loginBtn);
        Font = new Font("Segoe UI", 14F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(5);
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button loginBtn;
    private Label loginTitleLbl;
    private TextBox usernameTxt;
    private Label usernameLbl;
    private Label passwordLbl;
    private TextBox passwordTxt;
    private LinkLabel registerLbl;
}
