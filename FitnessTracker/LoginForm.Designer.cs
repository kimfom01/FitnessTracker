namespace FitnessTracker
{
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
            welcomeLbl = new Label();
            emailTxt = new TextBox();
            emailLbl = new Label();
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
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Location = new Point(194, 46);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(241, 25);
            welcomeLbl.TabIndex = 1;
            welcomeLbl.Text = "Welcome To Fitness Tracker";
            // 
            // emailTxt
            // 
            emailTxt.Location = new Point(74, 151);
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "Enter email address";
            emailTxt.Size = new Size(489, 32);
            emailTxt.TabIndex = 1;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Location = new Point(74, 114);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(134, 25);
            emailLbl.TabIndex = 3;
            emailLbl.Text = "Email Address:";
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
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(registerLbl);
            Controls.Add(passwordTxt);
            Controls.Add(passwordLbl);
            Controls.Add(emailLbl);
            Controls.Add(emailTxt);
            Controls.Add(welcomeLbl);
            Controls.Add(loginBtn);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBtn;
        private Label welcomeLbl;
        private TextBox emailTxt;
        private Label emailLbl;
        private Label passwordLbl;
        private TextBox passwordTxt;
        private LinkLabel registerLbl;
    }
}
