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
    public partial class Inventry : Form
    {
        public Inventry()
        {
            InitializeComponent();
        }

        private void Inventry_Load(object sender, EventArgs e)
        {

        }

        private void memberShipNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (equipmentNameTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is Added");
            }
            else
            {
                MessageBox.Show("Please fill input Field");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (equipmentNameTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is Updated");
            }
            else
            {
                MessageBox.Show("Please fill input Field");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (equipmentNameTextBox.Text != "")
            {
                MessageBox.Show("Congratulations! The Data is Deleted");
            }
            else
            {
                MessageBox.Show("Please fill input Field");
            }
        }
    }
}
