using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JYM_Project
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(UserNameTextBox.Text != "" && PasswordTextBox.Text != "" && RoleComboBox.Text != "")
            {
                MessageBox.Show("Congratulations! Your Data is sent");
                Manage ManageForm = new Manage();
                ManageForm.Show();
                
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }

        private void signupLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup SignupForm = new Signup();

            SignupForm.Show();
        }
    }
}
