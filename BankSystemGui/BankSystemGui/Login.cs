﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MyProjects.Services;
using MyProjects.Repository;

namespace BankSystemGui
{
    public partial class Login : Form
    {
        public static string username;
        public static string password;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            
          
            if(username == "SAMPLE1" && password == "SAMPLEPASSWORD")
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                displayIncorrect.Text = "Incorrect Login";
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if(e.KeyChar == (char)Keys.Enter)
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            */
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount1 c1 = new CreateAccount1(); 
            c1.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
