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

            bool nextStep = CheckEnterLoginPassword(login, password);
            nextStep = CheckLogin(nextStep, login);

            if (nextStep == true)
            {
                this.Hide();
                ChooseMenu chooseMenu = new ChooseMenu();
                chooseMenu.Show();
            }

        }

        public bool CheckEnterLoginPassword(string login, string password)
        {
            errorProviderMainMenu.Clear();

            if (login == string.Empty)
            {
                Error(labelLogin, "You enter empty Login!");
            }

            if (password == string.Empty)
            {
                Error(labelPassword, "You enter empty Password!");
            }

            if (login == string.Empty || password == string.Empty)
            {
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

                foreach (var user in users)
                {
                    if (user.UserName == login)
                    {
                        return true;
                    }
                    Error(buttonEnterLoginPassword, "Login or Password doesn't exist!");
                    return false;
                }
            }
            Error(buttonEnterLoginPassword, "Login or Password doesn't exist!");
            return false;
        }
    }
}
