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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }

        private void venderNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (venderNameTextBox.Text != "" && emailTextBox.Text != "" && contactNumberTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is added");  
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (venderNameTextBox.Text != "" && emailTextBox.Text != "" && contactNumberTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is updated");
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (venderNameTextBox.Text != "" && emailTextBox.Text != "" && contactNumberTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is deleted");
            }
            else
            {
                MessageBox.Show("Please fill all input Fields ");
            }
        }
    }
}
