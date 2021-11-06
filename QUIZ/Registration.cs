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
            string email = textBoxEmail.Text;
            string dateOfBirth = (dateTimePickerDateOfBirth.Value).ToString("yyyy-MM-dd");

            if (CheckInputData(name, password, repeatPassword, email, dateOfBirth) == true)
            {
                DataBase db = new DataBase();
                db.RegisterNewGamer(name, password, email, dateOfBirth);

                this.Close();

                MainMenu MainMenu = new MainMenu();
                MainMenu.Activate();
            }
        }

        public bool CheckInputData(string name, string password, string repeatPassword, string email, string dateOfBirth)
        {
            errorProviderRegistration.Clear();

            if (name == string.Empty)
            {
                Error(labelName, "You enter empty Name");
                return false;
            }

            if (password == string.Empty)
            {
                Error(labelPassword, "You enter empty Password");
                return false;
            }

            if (password != repeatPassword)
            {
                Error(labelRepeatPassword, "Password and Repeat password mismatch");
                return false;
            }

            if (email == string.Empty)
            {
                Error(labelEmail, "You enter empty E-mail");
                return false;
            }

            string compare = (DateTime.Now).ToString("yyyy-MM-dd");
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
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();
        }
    }
}
