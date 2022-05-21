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
            this.EnterForgotPasswordConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterForgotPasswordUserName = new System.Windows.Forms.TextBox();
            this.EnterForgotPasswordPassword = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ButtonForgotPasswordBack = new System.Windows.Forms.Button();
            this.ButtonConfirm = new System.Windows.Forms.Button();
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
            // EnterForgotPasswordConfirmPassword
            // 
            this.EnterForgotPasswordConfirmPassword.Location = new System.Drawing.Point(299, 288);
            this.EnterForgotPasswordConfirmPassword.Name = "EnterForgotPasswordConfirmPassword";
            this.EnterForgotPasswordConfirmPassword.Size = new System.Drawing.Size(203, 23);
            this.EnterForgotPasswordConfirmPassword.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confirm Password";
            // 
            // EnterForgotPasswordUserName
            // 
            this.EnterForgotPasswordUserName.Location = new System.Drawing.Point(299, 157);
            this.EnterForgotPasswordUserName.Name = "EnterForgotPasswordUserName";
            this.EnterForgotPasswordUserName.Size = new System.Drawing.Size(203, 23);
            this.EnterForgotPasswordUserName.TabIndex = 20;
            // 
            // EnterForgotPasswordPassword
            // 
            this.EnterForgotPasswordPassword.Location = new System.Drawing.Point(299, 219);
            this.EnterForgotPasswordPassword.Name = "EnterForgotPasswordPassword";
            this.EnterForgotPasswordPassword.Size = new System.Drawing.Size(203, 23);
            this.EnterForgotPasswordPassword.TabIndex = 19;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(299, 201);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(57, 15);
            this.PasswordLabel.TabIndex = 18;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(299, 139);
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
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonForgotPasswordBack);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.EnterForgotPasswordConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterForgotPasswordUserName);
            this.Controls.Add(this.EnterForgotPasswordPassword);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.TitleForgotPassword);
            this.Name = "Forgot_Password";
            this.Text = "Forgot_Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleForgotPassword;
        private TextBox EnterForgotPasswordConfirmPassword;
        private Label label1;
        private TextBox EnterForgotPasswordUserName;
        private TextBox EnterForgotPasswordPassword;
        private Label PasswordLabel;
        private Label UserNameLabel;
        private Button ButtonForgotPasswordBack;
        private Button ButtonConfirm;
    }
}