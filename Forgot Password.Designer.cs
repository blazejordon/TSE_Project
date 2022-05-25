namespace TSE
{
    partial class Forgot_Password
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
            this.TitleForgotPassword = new System.Windows.Forms.Label();
            this.EnterForgotPasswordUserName = new System.Windows.Forms.TextBox();
            this.EnterForgotPasswordEmail = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ButtonForgotPasswordBack = new System.Windows.Forms.Button();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.OutputPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterEmailCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleForgotPassword
            // 
            this.TitleForgotPassword.AutoSize = true;
            this.TitleForgotPassword.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleForgotPassword.Location = new System.Drawing.Point(12, 9);
            this.TitleForgotPassword.Name = "TitleForgotPassword";
            this.TitleForgotPassword.Size = new System.Drawing.Size(421, 59);
            this.TitleForgotPassword.TabIndex = 3;
            this.TitleForgotPassword.Text = "Forgot Password";
            // 
            // EnterForgotPasswordUserName
            // 
            this.EnterForgotPasswordUserName.Location = new System.Drawing.Point(190, 157);
            this.EnterForgotPasswordUserName.Name = "EnterForgotPasswordUserName";
            this.EnterForgotPasswordUserName.Size = new System.Drawing.Size(203, 23);
            this.EnterForgotPasswordUserName.TabIndex = 20;
            // 
            // EnterForgotPasswordEmail
            // 
            this.EnterForgotPasswordEmail.Location = new System.Drawing.Point(190, 219);
            this.EnterForgotPasswordEmail.Name = "EnterForgotPasswordEmail";
            this.EnterForgotPasswordEmail.Size = new System.Drawing.Size(203, 23);
            this.EnterForgotPasswordEmail.TabIndex = 19;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(190, 201);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(36, 15);
            this.EmailLabel.TabIndex = 18;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(190, 139);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(60, 15);
            this.UserNameLabel.TabIndex = 17;
            this.UserNameLabel.Text = "Username";
            // 
            // ButtonForgotPasswordBack
            // 
            this.ButtonForgotPasswordBack.Location = new System.Drawing.Point(240, 382);
            this.ButtonForgotPasswordBack.Name = "ButtonForgotPasswordBack";
            this.ButtonForgotPasswordBack.Size = new System.Drawing.Size(83, 45);
            this.ButtonForgotPasswordBack.TabIndex = 24;
            this.ButtonForgotPasswordBack.Text = "Back";
            this.ButtonForgotPasswordBack.UseVisualStyleBackColor = true;
            this.ButtonForgotPasswordBack.Click += new System.EventHandler(this.ButtonForgotPasswordBack_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Location = new System.Drawing.Point(329, 371);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(136, 67);
            this.ButtonConfirm.TabIndex = 23;
            this.ButtonConfirm.Text = "Send Code";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // OutputPassword
            // 
            this.OutputPassword.Location = new System.Drawing.Point(418, 219);
            this.OutputPassword.Name = "OutputPassword";
            this.OutputPassword.ReadOnly = true;
            this.OutputPassword.Size = new System.Drawing.Size(203, 23);
            this.OutputPassword.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Saved Password:";
            // 
            // EnterEmailCode
            // 
            this.EnterEmailCode.Location = new System.Drawing.Point(418, 157);
            this.EnterEmailCode.Name = "EnterEmailCode";
            this.EnterEmailCode.Size = new System.Drawing.Size(203, 23);
            this.EnterEmailCode.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Enter Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 60);
            this.label3.TabIndex = 29;
            this.label3.Text = "Enter Username and Email, if they are a registered \r\nuser, Health Assist will sen" +
    "d an email with a one \r\ntime code. This code is to input to the right \r\nto retri" +
    "eve the password of the account.";
            // 
            // CheckCode
            // 
            this.CheckCode.Location = new System.Drawing.Point(472, 256);
            this.CheckCode.Name = "CheckCode";
            this.CheckCode.Size = new System.Drawing.Size(83, 45);
            this.CheckCode.TabIndex = 30;
            this.CheckCode.Text = "Enter Code";
            this.CheckCode.UseVisualStyleBackColor = true;
            this.CheckCode.Click += new System.EventHandler(this.CheckCode_Click);
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnterEmailCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputPassword);
            this.Controls.Add(this.ButtonForgotPasswordBack);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.EnterForgotPasswordUserName);
            this.Controls.Add(this.EnterForgotPasswordEmail);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.TitleForgotPassword);
            this.Name = "Forgot_Password";
            this.Text = "Forgot_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleForgotPassword;
        private TextBox EnterForgotPasswordUserName;
        private TextBox EnterForgotPasswordEmail;
        private Label EmailLabel;
        private Label UserNameLabel;
        private Button ButtonForgotPasswordBack;
        private Button ButtonConfirm;
        private TextBox OutputPassword;
        private Label label1;
        private TextBox EnterEmailCode;
        private Label label2;
        private Label label3;
        private Button CheckCode;
    }
}