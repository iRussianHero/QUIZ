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
        private void StartNewQUIZ(object sender, EventArgs e)
        {
            buttonStartNewQUIZ.Hide();
            buttonTheme1.Show();
            buttonTheme2.Show();
        }
    }
}
