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
    public partial class CreateAccount2 : Form
    {
        public static string state;
        public static string city;
        public static int zip;
        public static string address;

        public CreateAccount2()
        {
            InitializeComponent();
        }
          
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home();
            h.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            state = txtStateCreate.Text;
            city = txtCityCreate.Text;
            zip = Int32.Parse(txtZipCreate.Text);
            address = txtAddressCreate.Text;

            lblFirst.Text = CreateAccount1.firstName;
            lblLast.Text = CreateAccount1.lastName;
            lblUser.Text = CreateAccount1.userName;
            lblPass.Text = CreateAccount1.password;
            lblEmail.Text = CreateAccount1.email;
            lblPhone.Text = CreateAccount1.phonenumber;
            DateTime dateUpdate = CreateAccount1.dateOfBirth;
            lblDate.Text = dateUpdate.ToString("M/d/yyyy");
            lblState.Text = state;
            lblCity.Text = city;
            lblZip.Text = zip.ToString();
            lblAddress.Text = address;
        }
    }
}
