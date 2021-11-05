using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else textBoxPassword.UseSystemPasswordChar = true;
        }

        private void Error(Control name, string error)
        {
            errorProviderMainMenu.SetIconAlignment(name, ErrorIconAlignment.MiddleLeft);
            errorProviderMainMenu.SetError(name, error);
        }

        private void buttonEnterLoginPassword_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            ChooseMenu chooseMenu = new ChooseMenu(login); //TODO Доделать локальное хранение логина для передачи в формы

            bool nextStep = CheckEnterLoginPassword(login, password);
            nextStep = CheckLogin(nextStep, login);
            nextStep = CheckPassword(nextStep, password);

            if (nextStep == true)
            {
                ChooseMenu ChooseMenu = new ChooseMenu(login);
                ChooseMenu.Show();
                this.Hide();
            }
        }

        public bool CheckEnterLoginPassword(string login, string password)
        {
            errorProviderMainMenu.Clear();

            if (login == string.Empty)
            {
                Error(labelLogin, "You enter empty Login");
                return false;
            }

            if (password == string.Empty)
            {
                Error(labelPassword, "You enter empty Password");
                return false;
            }

            return true;
        }

        public bool CheckLogin(bool nextStep, string login)
        {
            var db = new DataBase();

            if (nextStep == true)
            {
                var users = new List<Users>();
                users = db.UsersData();
                bool checkLogin = false;
                foreach (var user in users)
                {
                    if (user.UserName == login)
                    {
                        checkLogin = true;
                    }
                }
                if (!checkLogin)
                {
                    Error(buttonEnterLoginPassword, "Login or Password doesn't exist");
                    return false;
                }
                return true;
            }
            Error(buttonEnterLoginPassword, "Login or Password doesn't exist");
            return false;
        }

        public bool CheckPassword(bool nextStep, string password)
        {
            var db = new DataBase();

            if (nextStep == true)
            {
                var users = new List<Users>();
                users = db.UsersData();
                bool checkLogin = false;
                foreach (var user in users)
                {
                    if (user.UserPassword == password)
                    {
                        checkLogin = true;
                    }
                }
                if (!checkLogin)
                {
                    Error(buttonEnterLoginPassword, "Login or Password doesn't exist");
                    return false;
                }
                return true;
            }
            Error(buttonEnterLoginPassword, "Login or Password doesn't exist");
            return false;
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Registration Registration = new Registration();
            this.Hide();
            Registration.Show();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
