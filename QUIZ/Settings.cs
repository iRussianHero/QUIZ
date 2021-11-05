﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        public Settings(string data)
        {
            InitializeComponent();
            labelUserName.Text = data;
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            string login = labelUserName.Text;
            string newPassword = textBoxNewPassword.Text;

            if (newPassword == string.Empty)
            {
                Error(labelChangePassword, "Enter new Password");
            }

            db.ChangePassword(login, newPassword);

            labelPasswordChangeSucsess.Visible = true;
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            ChooseMenu ChooseMenu = new ChooseMenu();
            ChooseMenu.Close();
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            this.Close();
            ChooseMenu ChooseMenu = new ChooseMenu();
            ChooseMenu.Show();
        }

        private void Error(Control name, string error)
        {
            errorProviderSettings.SetIconAlignment(name, ErrorIconAlignment.MiddleLeft);
            errorProviderSettings.SetError(name, error);
        }
    }
}
