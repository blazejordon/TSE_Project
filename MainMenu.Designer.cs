﻿namespace TSE
{
    partial class MainMenu
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
            this.Title = new System.Windows.Forms.Label();
            this.StartLogging = new System.Windows.Forms.Button();
            this.StopLogging = new System.Windows.Forms.Button();
            this.EndProgram = new System.Windows.Forms.Button();
            this.UserStats = new System.Windows.Forms.Button();
            this.Signout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(283, 59);
            this.Title.TabIndex = 0;
            this.Title.Text = "Main Menu";
            // 
            // StartLogging
            // 
            this.StartLogging.Location = new System.Drawing.Point(12, 118);
            this.StartLogging.Name = "StartLogging";
            this.StartLogging.Size = new System.Drawing.Size(136, 67);
            this.StartLogging.TabIndex = 1;
            this.StartLogging.Text = "Start";
            this.StartLogging.UseVisualStyleBackColor = true;
            // 
            // StopLogging
            // 
            this.StopLogging.BackColor = System.Drawing.SystemColors.Control;
            this.StopLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StopLogging.Location = new System.Drawing.Point(159, 118);
            this.StopLogging.Name = "StopLogging";
            this.StopLogging.Size = new System.Drawing.Size(136, 67);
            this.StopLogging.TabIndex = 2;
            this.StopLogging.Text = "Stop";
            this.StopLogging.UseVisualStyleBackColor = true;
            // 
            // EndProgram
            // 
            this.EndProgram.Location = new System.Drawing.Point(652, 371);
            this.EndProgram.Name = "EndProgram";
            this.EndProgram.Size = new System.Drawing.Size(136, 67);
            this.EndProgram.TabIndex = 3;
            this.EndProgram.Text = "End";
            this.EndProgram.UseVisualStyleBackColor = true;
            this.EndProgram.Click += new System.EventHandler(this.EndProgram_Click);
            // 
            // UserStats
            // 
            this.UserStats.Location = new System.Drawing.Point(12, 242);
            this.UserStats.Name = "UserStats";
            this.UserStats.Size = new System.Drawing.Size(137, 63);
            this.UserStats.TabIndex = 4;
            this.UserStats.Text = "Statistics";
            this.UserStats.UseVisualStyleBackColor = true;
            this.UserStats.Click += new System.EventHandler(this.UserStats_Click);
            // 
            // Signout
            // 
            this.Signout.Location = new System.Drawing.Point(12, 371);
            this.Signout.Name = "Signout";
            this.Signout.Size = new System.Drawing.Size(137, 63);
            this.Signout.TabIndex = 5;
            this.Signout.Text = "Sign Out";
            this.Signout.UseVisualStyleBackColor = true;
            this.Signout.Click += new System.EventHandler(this.Signout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Signout);
            this.Controls.Add(this.UserStats);
            this.Controls.Add(this.EndProgram);
            this.Controls.Add(this.StopLogging);
            this.Controls.Add(this.StartLogging);
            this.Controls.Add(this.Title);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Button StartLogging;
        private Button StopLogging;
        private Button EndProgram;
        private Button UserStats;
        private Button Signout;
    }
}