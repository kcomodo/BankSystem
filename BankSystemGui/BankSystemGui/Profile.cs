using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyProjects.Models;
using MyProjects.Services;
using MyProjects;
namespace BankSystemGui
{
    public partial class Profile : Form
    {
        BankServices bank = new BankServices();
        InfoModel model = new InfoModel();
       
        public Profile()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
      
        
        }

        private void Home_Load(object sender, EventArgs e)
        {

            string name = Login.username;
            string password = Login.password;
           



        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void middlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOthers_Click(object sender, EventArgs e)
        {

        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
