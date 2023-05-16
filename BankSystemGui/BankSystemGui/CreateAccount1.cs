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
        public CreateAccount1()
        {
            InitializeComponent();
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

                    testFirst.Text = firstName;
                    testLast.Text = lastName;
                    testUser.Text = userName;
                    testPass.Text = password;
                    testEmail.Text = email;
                    testPhone.Text = phonenumber;
                    testDate.Text = dateEdit.Value.ToString("M/d/yyyy h:mm:ss tt");
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

        private void txtFirstNameCreate_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkButton_Click(object sender, EventArgs e)
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

                testFirst.Text = firstName;
                testLast.Text = lastName;
                testUser.Text = userName;
                testPass.Text = password;
                testEmail.Text = email;
                testPhone.Text = phonenumber;
                testDate.Text = dateEdit.Value.ToString("M/d/yyyy h:mm:ss tt");
  
            }
            if(!validationPassword)
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

        private void txtPassCreate_TextChanged(object sender, EventArgs e)
        {
            txtPassCreate.PasswordChar = '*';
        }

        private void CreateAccount1_Load(object sender, EventArgs e)
        {

        }
    }
}
