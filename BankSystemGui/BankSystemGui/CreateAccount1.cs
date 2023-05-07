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
    public partial class CreateAccount1 : Form
    {
        public static string firstName;
        public static string lastName;  
        public static string email;
        public static string userName;
        public static string password;
        public static char phonenumber;

        CreateAccount2 c2 = new CreateAccount2();

        public CreateAccount1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            this.Hide();
            firstName = txtFirstNameCreate.Text;
            lastName = txtLastNameCreate.Text;
            userName = txtUserCreate.Text;
            password = txtPassCreate.Text;
            c2.Show();

        }
    }
}
