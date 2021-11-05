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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void ChangePassword(object sender, EventArgs e)
        {
            var db = new DataBase();
            var users = new List<Users>();
            string newPassword = textBoxNewPassword.Text;

            users = db.UsersData();
            foreach (var item in users)
            {

            }
        }
        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
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
