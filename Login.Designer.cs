namespace TSE
{
    partial class Login
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
            this.ButtonRegister = new System.Windows.Forms.Button();
            this.EnterUserName = new System.Windows.Forms.TextBox();
            this.EnterPassword = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.TitleLogin = new System.Windows.Forms.Label();
            this.ForgotPasswordButton = new System.Windows.Forms.Button();
            this.IncorrectLoginMessage = new System.Windows.Forms.Label();
            this.EnterEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.Location = new System.Drawing.Point(240, 382);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(83, 45);
            this.ButtonRegister.TabIndex = 26;
            this.ButtonRegister.Text = "Register";
            this.ButtonRegister.UseVisualStyleBackColor = true;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // EnterUserName
            // 
            this.EnterUserName.Location = new System.Drawing.Point(296, 159);
            this.EnterUserName.Name = "EnterUserName";
            this.EnterUserName.Size = new System.Drawing.Size(203, 23);
            this.EnterUserName.TabIndex = 23;
            // 
            // EnterPassword
            // 
            this.EnterPassword.Location = new System.Drawing.Point(296, 287);
            this.EnterPassword.Name = "EnterPassword";
            this.EnterPassword.Size = new System.Drawing.Size(203, 23);
            this.EnterPassword.TabIndex = 22;
            this.EnterPassword.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(296, 269);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 21;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(296, 141);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(60, 15);
            this.UserNameLabel.TabIndex = 20;
            this.UserNameLabel.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(329, 371);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(136, 67);
            this.LoginButton.TabIndex = 19;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // TitleLogin
            // 
            this.TitleLogin.AutoSize = true;
            this.TitleLogin.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLogin.Location = new System.Drawing.Point(12, 9);
            this.TitleLogin.Name = "TitleLogin";
            this.TitleLogin.Size = new System.Drawing.Size(179, 59);
            this.TitleLogin.TabIndex = 18;
            this.TitleLogin.Text = "Log In";
            // 
            // ForgotPasswordButton
            // 
            this.ForgotPasswordButton.Location = new System.Drawing.Point(471, 382);
            this.ForgotPasswordButton.Name = "ForgotPasswordButton";
            this.ForgotPasswordButton.Size = new System.Drawing.Size(83, 45);
            this.ForgotPasswordButton.TabIndex = 27;
            this.ForgotPasswordButton.Text = "Forgot Password";
            this.ForgotPasswordButton.UseVisualStyleBackColor = true;
            this.ForgotPasswordButton.Click += new System.EventHandler(this.ForgotPasswordButton_Click);
            // 
            // IncorrectLoginMessage
            // 
            this.IncorrectLoginMessage.AutoSize = true;
            this.IncorrectLoginMessage.ForeColor = System.Drawing.Color.Red;
            this.IncorrectLoginMessage.Location = new System.Drawing.Point(306, 232);
            this.IncorrectLoginMessage.Name = "IncorrectLoginMessage";
            this.IncorrectLoginMessage.Size = new System.Drawing.Size(0, 15);
            this.IncorrectLoginMessage.TabIndex = 28;
            this.IncorrectLoginMessage.Visible = false;
            // 
            // EnterEmail
            // 
            this.EnterEmail.Location = new System.Drawing.Point(296, 224);
            this.EnterEmail.Name = "EnterEmail";
            this.EnterEmail.Size = new System.Drawing.Size(203, 23);
            this.EnterEmail.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Email";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncorrectLoginMessage);
            this.Controls.Add(this.ForgotPasswordButton);
            this.Controls.Add(this.ButtonRegister);
            this.Controls.Add(this.EnterUserName);
            this.Controls.Add(this.EnterPassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TitleLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonRegister;
        private TextBox EnterUserName;
        private TextBox EnterPassword;
        private Label PasswordLabel;
        private Label UserNameLabel;
        private Button LoginButton;
        private Label TitleLogin;
        private Button ForgotPasswordButton;
        private Label IncorrectLoginMessage;
        private TextBox EnterEmail;
        private Label label1;
    }
}