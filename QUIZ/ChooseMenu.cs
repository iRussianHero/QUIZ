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
    public partial class ChooseMenu : Form
    {
        public ChooseMenu()
        {
            InitializeComponent();
        }
        public ChooseMenu(string data)
        {
            InitializeComponent();
            labelUserName.Text = data;
        }
        private void StartNewQUIZ(object sender, EventArgs e)
        {
            buttonStartNewQUIZ.Hide();
            buttonTheme1.Show();
            buttonTheme2.Show();
            buttonRandomTheme.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Settings Settings = new Settings(labelUserName.Text);
            this.Hide();
            Settings.Show();
        }

        private void ChooseMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenu MainMenu = new MainMenu();
            MainMenu.Close();
        }
    }
}
