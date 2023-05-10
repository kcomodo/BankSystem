using MyProjects.Models;
using MyProjects.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BankSystemGui
{
    public partial class Home : Form
    {
        BankServices bank = new BankServices();
        InfoModel model = new InfoModel();
        public Home()
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

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
