
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
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonChangeDateOfBirthday = new System.Windows.Forms.Button();
            this.errorProviderSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPasswordChangeSucsess = new System.Windows.Forms.Label();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelDayOfBirthdayChangeSucsess = new System.Windows.Forms.Label();
            this.labelCurrentDateoOfBirth = new System.Windows.Forms.Label();
            this.textBoxCurrentDateOfBirth = new System.Windows.Forms.TextBox();
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
            this.buttonChangePassword.Click += new System.EventHandler(this.ChangePassword);
            // 
            // buttonChangeDateOfBirthday
            // 
            this.buttonChangeDateOfBirthday.Location = new System.Drawing.Point(539, 240);
            this.buttonChangeDateOfBirthday.Name = "buttonChangeDateOfBirthday";
            this.buttonChangeDateOfBirthday.Size = new System.Drawing.Size(164, 23);
            this.buttonChangeDateOfBirthday.TabIndex = 6;
            this.buttonChangeDateOfBirthday.Text = "Change date of birthday";
            this.buttonChangeDateOfBirthday.UseVisualStyleBackColor = true;
            this.buttonChangeDateOfBirthday.Click += new System.EventHandler(this.ChangeDateOfBirthday);
            // 
            // errorProviderSettings
            // 
            this.errorProviderSettings.BlinkRate = 0;
            this.errorProviderSettings.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSettings.ContainerControl = this;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(12, 22);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(33, 13);
            this.labelUserName.TabIndex = 7;
            this.labelUserName.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "UserName:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(325, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BackToMenu);
            // 
            // labelPasswordChangeSucsess
            // 
            this.labelPasswordChangeSucsess.AutoSize = true;
            this.labelPasswordChangeSucsess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordChangeSucsess.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelPasswordChangeSucsess.Location = new System.Drawing.Point(81, 266);
            this.labelPasswordChangeSucsess.Name = "labelPasswordChangeSucsess";
            this.labelPasswordChangeSucsess.Size = new System.Drawing.Size(246, 20);
            this.labelPasswordChangeSucsess.TabIndex = 11;
            this.labelPasswordChangeSucsess.Text = "Password updated - Sucsess!";
            this.labelPasswordChangeSucsess.Visible = false;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.CustomFormat = "";
            this.dateTimePickerDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(539, 214);
            this.dateTimePickerDateOfBirth.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 12;
            this.dateTimePickerDateOfBirth.Value = new System.DateTime(2021, 11, 3, 0, 0, 0, 0);
            // 
            // labelDayOfBirthdayChangeSucsess
            // 
            this.labelDayOfBirthdayChangeSucsess.AutoSize = true;
            this.labelDayOfBirthdayChangeSucsess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayOfBirthdayChangeSucsess.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelDayOfBirthdayChangeSucsess.Location = new System.Drawing.Point(447, 266);
            this.labelDayOfBirthdayChangeSucsess.Name = "labelDayOfBirthdayChangeSucsess";
            this.labelDayOfBirthdayChangeSucsess.Size = new System.Drawing.Size(292, 20);
            this.labelDayOfBirthdayChangeSucsess.TabIndex = 13;
            this.labelDayOfBirthdayChangeSucsess.Text = "Day of Birthday updated - Sucsess!";
            this.labelDayOfBirthdayChangeSucsess.Visible = false;
            // 
            // labelCurrentDateoOfBirth
            // 
            this.labelCurrentDateoOfBirth.AutoSize = true;
            this.labelCurrentDateoOfBirth.Location = new System.Drawing.Point(413, 186);
            this.labelCurrentDateoOfBirth.Name = "labelCurrentDateoOfBirth";
            this.labelCurrentDateoOfBirth.Size = new System.Drawing.Size(120, 13);
            this.labelCurrentDateoOfBirth.TabIndex = 14;
            this.labelCurrentDateoOfBirth.Text = "Current date of birthday:";
            // 
            // textBoxCurrentDateOfBirth
            // 
            this.textBoxCurrentDateOfBirth.Location = new System.Drawing.Point(539, 183);
            this.textBoxCurrentDateOfBirth.Name = "textBoxCurrentDateOfBirth";
            this.textBoxCurrentDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.textBoxCurrentDateOfBirth.TabIndex = 15;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCurrentDateOfBirth);
            this.Controls.Add(this.labelCurrentDateoOfBirth);
            this.Controls.Add(this.labelDayOfBirthdayChangeSucsess);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.labelPasswordChangeSucsess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonChangeDateOfBirthday);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelChangeDateOfBirth);
            this.Controls.Add(this.labelChangePassword);
            this.Controls.Add(this.labelTitle);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.ShowDateOfBirth);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelChangePassword;
        private System.Windows.Forms.Label labelChangeDateOfBirth;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonChangeDateOfBirthday;
        private System.Windows.Forms.ErrorProvider errorProviderSettings;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPasswordChangeSucsess;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Label labelDayOfBirthdayChangeSucsess;
        private System.Windows.Forms.TextBox textBoxCurrentDateOfBirth;
        private System.Windows.Forms.Label labelCurrentDateoOfBirth;
    }
}