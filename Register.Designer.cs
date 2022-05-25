namespace TSE
{
    partial class Register
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
            this.TitleRegister = new System.Windows.Forms.Label();
            this.EnterRegisterUserName = new System.Windows.Forms.TextBox();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterBack = new System.Windows.Forms.Button();
            this.RegisterEmail = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleRegister
            // 
            this.TitleRegister.AutoSize = true;
            this.TitleRegister.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleRegister.Location = new System.Drawing.Point(12, 9);
            this.TitleRegister.Name = "TitleRegister";
            this.TitleRegister.Size = new System.Drawing.Size(222, 59);
            this.TitleRegister.TabIndex = 3;
            this.TitleRegister.Text = "Register";
            // 
            // EnterRegisterUserName
            // 
            this.EnterRegisterUserName.Location = new System.Drawing.Point(296, 159);
            this.EnterRegisterUserName.Name = "EnterRegisterUserName";
            this.EnterRegisterUserName.Size = new System.Drawing.Size(203, 23);
            this.EnterRegisterUserName.TabIndex = 14;
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Location = new System.Drawing.Point(296, 260);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.Size = new System.Drawing.Size(203, 23);
            this.RegisterPassword.TabIndex = 13;
            this.RegisterPassword.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(296, 242);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(296, 141);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(60, 15);
            this.UserNameLabel.TabIndex = 11;
            this.UserNameLabel.Text = "Username";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(329, 371);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(136, 67);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // RegisterConfirmPassword
            // 
            this.RegisterConfirmPassword.Location = new System.Drawing.Point(296, 315);
            this.RegisterConfirmPassword.Name = "RegisterConfirmPassword";
            this.RegisterConfirmPassword.Size = new System.Drawing.Size(203, 23);
            this.RegisterConfirmPassword.TabIndex = 16;
            this.RegisterConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Confirm Password";
            // 
            // RegisterBack
            // 
            this.RegisterBack.Location = new System.Drawing.Point(240, 382);
            this.RegisterBack.Name = "RegisterBack";
            this.RegisterBack.Size = new System.Drawing.Size(83, 45);
            this.RegisterBack.TabIndex = 17;
            this.RegisterBack.Text = "Back";
            this.RegisterBack.UseVisualStyleBackColor = true;
            this.RegisterBack.Click += new System.EventHandler(this.RegisterBack_Click);
            // 
            // RegisterEmail
            // 
            this.RegisterEmail.Location = new System.Drawing.Point(296, 207);
            this.RegisterEmail.Name = "RegisterEmail";
            this.RegisterEmail.Size = new System.Drawing.Size(203, 23);
            this.RegisterEmail.TabIndex = 19;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(296, 189);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegisterEmail);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.RegisterBack);
            this.Controls.Add(this.RegisterConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterRegisterUserName);
            this.Controls.Add(this.RegisterPassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.TitleRegister);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleRegister;
        private TextBox EnterRegisterUserName;
        private TextBox RegisterPassword;
        private Label PasswordLabel;
        private Label UserNameLabel;
        private Button RegisterButton;
        private TextBox RegisterConfirmPassword;
        private Label label1;
        private Button RegisterBack;
        private TextBox RegisterEmail;
        private Label EmailLabel;
    }
}