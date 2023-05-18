using BankSystemGui.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string phonenumber;
        public static DateTime dateOfBirth;
        BankServices bank = new BankServices();
        private string defaultFirstName = "First Name";
        private string defaultLastName = "Last Name";
        private string defaultUserName = "Username";
        private string defaultPassword = "Password";
        private string defaultEmail = "Email";
        private string defaultPhoneNumber = "Phone number";
        public CreateAccount1()
        {
            InitializeComponent();

            txtFirstNameCreate.Text = defaultFirstName;
            txtLastNameCreate.Text = defaultLastName;
            txtUserCreate.Text = defaultUserName;
            txtPassCreate.Text = defaultPassword;
            txtEmailCreate.Text = defaultEmail;
            txtPhoneNumberCreate.Text = defaultPhoneNumber;

            txtFirstNameCreate.ForeColor = System.Drawing.Color.Gray;
            txtFirstNameCreate.GotFocus += txtFirstName_GotFocus;
            txtFirstNameCreate.LostFocus += txtFirstName_GotFocus;

            txtLastNameCreate.ForeColor = System.Drawing.Color.Gray;
            txtLastNameCreate.GotFocus += txtLastName_GotFocus;
            txtLastNameCreate.LostFocus += txtLastName_LostFocus;

            txtUserCreate.ForeColor = System.Drawing.Color.Gray;
            txtUserCreate.GotFocus += txtUserName_GotFocus;
            txtUserCreate.LostFocus += txtUserName_LostFocus;

            txtPassCreate.ForeColor = System.Drawing.Color.Gray;
            txtPassCreate.GotFocus += txtPassword_GotFocus;
            txtPassCreate.LostFocus += txtPassword_LostFocus;

            txtEmailCreate.ForeColor = System.Drawing.Color.Gray;
            txtEmailCreate.GotFocus += txtEmail_GotFocus;
            txtEmailCreate.LostFocus += txtEmail_LostFocus;

            txtPhoneNumberCreate.ForeColor = System.Drawing.Color.Gray;
            txtPhoneNumberCreate.GotFocus += txtPhoneNumber_GotFocus;
            txtPhoneNumberCreate.LostFocus += txtPhoneNumber_LostFocus;

            exitBtn2.BackColor = Color.Transparent;
            exitBtn2.MouseEnter += button1_MouseEnter;
            exitBtn2.MouseLeave += button1_MouseLeave;

            exitBtn2.FlatAppearance.BorderSize = 0;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
                firstName = txtFirstNameCreate.Text;
                lastName = txtLastNameCreate.Text;
                userName = txtUserCreate.Text;
                password = txtPassCreate.Text;
                bool validationUserName = bank.validateUserName(txtUserCreate.Text);
                bool validationPassword = bank.validatePassword(txtPassCreate.Text);
                bool validationEmail = bank.validateEmail(txtEmailCreate.Text);
                bool validationPhone = bank.validatePhoneNumber(txtPhoneNumberCreate.Text);
                if (validationUserName && validationPassword && validationEmail & validationPhone)
                {
                    userName = txtUserCreate.Text;
                    password = txtPassCreate.Text;

                    phonenumber = Regex.Replace(txtPhoneNumberCreate.Text, @"[^0-9]", "");
                    if (phonenumber.Length > 3)
                    {
                        phonenumber = phonenumber.Insert(3, "-");
                    }
                    if (phonenumber.Length > 7)
                    {
                        phonenumber = phonenumber.Insert(7, "-");
                    }
                    email = txtEmailCreate.Text;
                    dateOfBirth = dateEdit.Value;
                this.Hide();
                CreateAccount2 c2 = new CreateAccount2();
                c2.Show();

            }
                if (!validationPassword)
                {
                    txtUserCreate.Text = "";
                    checkUsername.Text = "Invalid Username";
                }
                if (!validationPassword)
                {
                    txtPassCreate.Text = "";
                    checkPassword.Text = "Invalid Password";

                }
                if (!validationPhone)
                {
                    txtPhoneNumberCreate.Text = "";
                    checkPhoneNumber.Text = "Invalid Phone Number";
                }

                if (!validationEmail)
                {
                    txtEmailCreate.Text = "";
                    checkEmail.Text = "Invalid Email";
                }


            



        }
        private void txtFirstName_GotFocus(object sender, EventArgs e)
        {
            if (txtFirstNameCreate.Text == defaultFirstName)
            {
                txtFirstNameCreate.Text = "";
                txtFirstNameCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtFirstName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstNameCreate.Text))
            {
                txtFirstNameCreate.Text = defaultFirstName;
                txtFirstNameCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtLastName_GotFocus(object sender, EventArgs e)
        {
            if (txtLastNameCreate.Text == defaultLastName)
            {
                txtLastNameCreate.Text = "";
                txtLastNameCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtLastName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastNameCreate.Text))
            {
                txtLastNameCreate.Text = defaultLastName;
                txtLastNameCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtUserName_GotFocus(object sender, EventArgs e)
        {
            if (txtUserCreate.Text == defaultUserName)
            {
                txtUserCreate.Text = "";

                txtUserCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtUserName_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserCreate.Text))
            {
                txtUserCreate.Text = defaultUserName;
                txtUserCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassCreate.Text == defaultPassword)
            {
                txtPassCreate.Text = "";
                txtPassCreate.PasswordChar = '*';
                txtPassCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassCreate.Text))
            {
                txtPassCreate.Text = defaultPassword;
                txtPassCreate.PasswordChar = '\u0000';
                txtPassCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtEmail_GotFocus(object sender, EventArgs e)
        {
            if (txtEmailCreate.Text == defaultEmail)
            {
                txtEmailCreate.Text = "";
                txtEmailCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtEmail_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailCreate.Text))
            {
                txtEmailCreate.Text = defaultEmail;
                txtEmailCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtPhoneNumber_GotFocus(object sender, EventArgs e)
        {
            if (txtPhoneNumberCreate.Text == defaultPhoneNumber)
            {
                txtPhoneNumberCreate.Text = "";
                txtPhoneNumberCreate.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtPhoneNumber_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumberCreate.Text))
            {
                txtPhoneNumberCreate.Text = defaultPassword;
                txtPhoneNumberCreate.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            exitBtn2.BackColor = Color.Transparent;

            exitBtn2.FlatAppearance.BorderSize = 0;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            exitBtn2.BackColor = Color.Transparent; // Set the desired background color when not hovered over

            exitBtn2.FlatAppearance.BorderSize = 0;
        }

        private void txtFirstNameCreate_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void txtPassCreate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CreateAccount1_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
