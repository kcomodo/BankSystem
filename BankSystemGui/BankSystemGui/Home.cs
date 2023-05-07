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
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        
        }

        private void Home_Load(object sender, EventArgs e)
        {
           lblDisplayName.Text= CreateAccount1.firstName;
        }

        private void lblHello_Click(object sender, EventArgs e)
        {

        }
    }
}
