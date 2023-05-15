using BankSystemGui.Services;
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
            
            this.Hide();
            try
            {
                firstName = txtFirstNameCreate.Text;
                lastName = txtLastNameCreate.Text;
               
                bool validationUserName = bank.validateUserName(txtUserCreate.Text);
                bool validationPassword = bank.validatePassword(txtPassCreate.Text);
                bool validationEmail = bank.validateEmail(txtEmailCreate.Text);
                if(validationUserName)
                {
                    userName = txtUserCreate.Text;
                    
                }
                else
                {
                    txtUserCreate.Text = "";
                    checkUsername.Text = "Invalid Username";
                }
                if (validationPassword)
                {
                    password = txtPassCreate.Text;

                }
                else
                {
                    txtPassCreate.Text = "";
                    checkPassword.Text = "Invalid Password";
                }

                phonenumber = txtPhoneNumberCreate.Text;
                dateOfBirth = dateEdit.Value;
                
                if (validationEmail)
                {
                    email = txtEmailCreate.Text;
                    CreateAccount2 c2 = new CreateAccount2();
                    c2.Show();
                }
                else
                {
                    txtEmailCreate.Text = "";
                    checkEmail.Text = "Invalid Email";
                }
            }
            catch
            {

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
            if (validationUserName)
            {
                userName = txtUserCreate.Text;

            }
            else
            {
                txtUserCreate.Text = "";
                checkUsername.Text = "Invalid Username";
            }
            if (validationPassword)
            {
                password = txtPassCreate.Text;

            }
            else
            {
                txtPassCreate.Text = "";
                checkPassword.Text = "Invalid Password";
            }
            if (validationEmail)
            {
                email = txtEmailCreate.Text;
                CreateAccount2 c2 = new CreateAccount2();
                c2.Show();
            }
            else
            {
                txtEmailCreate.Text = "";
                checkEmail.Text = "Invalid Email";
            }
           
            phonenumber = txtPhoneNumberCreate.Text;
            dateOfBirth = dateEdit.Value;

            testFirst.Text = firstName;
            testLast.Text = lastName; 
            testUser.Text = userName;
            testPass.Text = password;
            testEmail.Text = email;
            testPhone.Text = phonenumber;
            testDate.Text = dateEdit.Value.ToString("M/d/yyyy");
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
