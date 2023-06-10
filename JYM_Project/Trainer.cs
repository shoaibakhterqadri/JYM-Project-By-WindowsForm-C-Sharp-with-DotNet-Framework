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
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != ""  && phoneNumberTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is Added");
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && phoneNumberTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is Updated");
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "" && emailTextBox.Text != "" && phoneNumberTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is Deleted");
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }
    }
}
