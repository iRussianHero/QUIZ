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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Error(Control name, string error)
        {
            errorProviderRegistration.SetIconAlignment(name, ErrorIconAlignment.MiddleLeft);
            errorProviderRegistration.SetError(name, error);
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string password = textBoxPassword.Text;
            string repeatPassword = textBoxRepeatPassword.Text;
            string dateOfBirth = dateTimePickerDateOfBirth.Text;

            if (CheckInputData(name, password, repeatPassword, dateOfBirth) == true)
            {
                DataBase DB = new DataBase();

            }
        }

        public bool CheckInputData(string name, string password, string repeatPassword, string dateOfBirth)
        {
            errorProviderRegistration.Clear();

            if (name == string.Empty)
            {
                Error(labelName, "You enter empty Name");
                return false;
            }

            if (password == string.Empty)
            {
                Error(labelPassword, "Yo enter empty Password");
                return false;
            }

            if (password != repeatPassword)
            {
                Error(labelRepeatPassword, "Password and Repeat password mismatch");
                return false;
            }

            string compare = (DateTime.Now).ToString("yyyy.MM.dd");
            if (dateOfBirth == compare)
            {
                Error(labelDateOfBirth, "You forgot change Date of Birth");
                return false;
            }

            var db = new DataBase();

            var users = new List<Users>();
            users = db.UsersData();

            foreach (var user in users)
            {
                if (user.UserName == name)
                {
                    Error(buttonRegister, "This Name alredy exist");
                    return false;
                }
            }

            return true;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }
    }
}
