using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemGui;
using BankSystemGui.Repository;
using BankSystemGui.Services;
using BankSystemGui.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms.VisualStyles;

namespace BankSystemGui
{
    public partial class CreateAccount2 : Form
    {
        public static string firstName;
        public static string lastName;
        public static string email;
        public static string userName;
        public static string password;
        public static string phonenumber;
        public static string state;
        public static string city;
        public static string Date;
        public static int zip;
        public static string address;

        private string defaultCity = "City";
        private string defaultZip = "Zip";
        private string defaultAddress = "Address";
        public CreateAccount2()
        {
            InitializeComponent();
            string[] states = {
        "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware",
        "Florida", "Georgia", "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
        "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota", "Mississippi", "Missouri",
        "Montana", "Nebraska", "Nevada", "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina",
        "North Dakota", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
        "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "West Virginia",
                    "Wisconsin", "Wyoming"
                };

            stateCombo.Items.AddRange(states);

            txtCityCreate.Text = defaultCity;
            txtZipCreate.Text = defaultZip;
            txtAddressCreate.Text = defaultAddress;

            txtCityCreate.ForeColor = System.Drawing.Color.Gray;
            txtCityCreate.GotFocus += txtCity_GotFocus;
            txtCityCreate.LostFocus += txtCity_LostFocus;

            txtZipCreate.ForeColor = System.Drawing.Color.Gray;
            txtZipCreate.GotFocus += txtZip_GotFocus;
            txtZipCreate.LostFocus += txtZip_LostFocus;

            txtAddressCreate.ForeColor = System.Drawing.Color.Gray;
            txtAddressCreate.GotFocus += txtAddress_GotFocus;
            txtAddressCreate.LostFocus += txtAddress_LostFocus;
        }
          
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            BankServices bank = new BankServices();
            firstName = CreateAccount1.firstName;
            lastName = CreateAccount1.lastName;
            email = CreateAccount1.email;
            userName = CreateAccount1.userName;
            password = CreateAccount1.password;
            phonenumber = CreateAccount1.phonenumber;
            DateTime dateUpdate = CreateAccount1.dateOfBirth;
            state = stateCombo.SelectedIndex.ToString();
            city = txtCityCreate.Text;
            zip = Int32.Parse(txtZipCreate.Text);
            address = txtAddressCreate.Text;
            bank.registerAccount(firstName, lastName, userName, email, state, city, zip, address, phonenumber, dateUpdate, password);
            this.Hide();
            Login l = new Login();
            l.Show();
            
            
        }
        private void txtCity_GotFocus(object sender, EventArgs e)
        {
            if (txtCityCreate.Text == defaultCity)
            {
                txtCityCreate.Text = "";
                txtCityCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtCity_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCityCreate.Text))
            {
                txtCityCreate.Text = defaultCity;
                txtCityCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtZip_GotFocus(object sender, EventArgs e)
        {
            if (txtZipCreate.Text == defaultZip)
            {
                txtZipCreate.Text = "";
                txtZipCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtZip_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZipCreate.Text))
            {
                txtZipCreate.Text = defaultZip;
                txtZipCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtAddress_GotFocus(object sender, EventArgs e)
        {
            if (txtAddressCreate.Text == defaultAddress)
            {
                txtAddressCreate.Text = "";
                txtAddressCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtAddress_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddressCreate.Text))
            {
                txtAddressCreate.Text = defaultAddress;
                txtAddressCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              

        }
    }
}
