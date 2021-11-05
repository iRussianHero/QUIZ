﻿
namespace QUIZ
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelChangePassword = new System.Windows.Forms.Label();
            this.labelChangeDateOfBirth = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonChangeDateOfBirthday = new System.Windows.Forms.Button();
            this.errorProviderSettings = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(286, 55);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(217, 24);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "What do you want to do?";
            // 
            // labelChangePassword
            // 
            this.labelChangePassword.AutoSize = true;
            this.labelChangePassword.Location = new System.Drawing.Point(61, 217);
            this.labelChangePassword.Name = "labelChangePassword";
            this.labelChangePassword.Size = new System.Drawing.Size(96, 13);
            this.labelChangePassword.TabIndex = 1;
            this.labelChangePassword.Text = "Change Password:";
            // 
            // labelChangeDateOfBirth
            // 
            this.labelChangeDateOfBirth.AutoSize = true;
            this.labelChangeDateOfBirth.Location = new System.Drawing.Point(410, 217);
            this.labelChangeDateOfBirth.Name = "labelChangeDateOfBirth";
            this.labelChangeDateOfBirth.Size = new System.Drawing.Size(123, 13);
            this.labelChangeDateOfBirth.TabIndex = 2;
            this.labelChangeDateOfBirth.Text = "Change date of birthday:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(578, 151);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.TodayDate = new System.DateTime(2021, 11, 5, 0, 0, 0, 0);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(162, 214);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(165, 20);
            this.textBoxNewPassword.TabIndex = 4;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(64, 240);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(263, 23);
            this.buttonChangePassword.TabIndex = 5;
            this.buttonChangePassword.Text = "Change password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            // 
            // buttonChangeDateOfBirthday
            // 
            this.buttonChangeDateOfBirthday.Location = new System.Drawing.Point(578, 325);
            this.buttonChangeDateOfBirthday.Name = "buttonChangeDateOfBirthday";
            this.buttonChangeDateOfBirthday.Size = new System.Drawing.Size(164, 23);
            this.buttonChangeDateOfBirthday.TabIndex = 6;
            this.buttonChangeDateOfBirthday.Text = "Change date of birthday";
            this.buttonChangeDateOfBirthday.UseVisualStyleBackColor = true;
            // 
            // errorProviderSettings
            // 
            this.errorProviderSettings.BlinkRate = 0;
            this.errorProviderSettings.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSettings.ContainerControl = this;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeDateOfBirthday);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelChangeDateOfBirth);
            this.Controls.Add(this.labelChangePassword);
            this.Controls.Add(this.labelTitle);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Label labelChangeDateOfBirth;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonChangeDateOfBirthday;
        private System.Windows.Forms.ErrorProvider errorProviderSettings;
    }
}