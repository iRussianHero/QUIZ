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
            string datOfBirth = dateTimePickerDateOfBirth.Text;


        }


    }
}
