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
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void ManageGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void trainerButton_Click(object sender, EventArgs e)
        {
            Trainer TrainerForm = new Trainer();
            TrainerForm.Show();
        }

        private void maintainerButton_Click(object sender, EventArgs e)
        {
            //Maintainer MaintainerForm = new Maintainer();
            //MaintainerForm.Show();
            Vender MaintainerForm = new Vender();
            MaintainerForm.Show();
        }

        private void inventryButton_Click(object sender, EventArgs e)
        {
            Inventry InventryForm = new Inventry();
            InventryForm.Show();
        }

        private void dealButton_Click(object sender, EventArgs e)
        {
            DealSection DealSectionForm = new DealSection();
            DealSectionForm.Show();
        }
    }
}
