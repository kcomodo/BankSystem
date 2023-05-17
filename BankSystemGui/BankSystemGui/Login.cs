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
using BankSystemGui;
using BankSystemGui.Repository;
using BankSystemGui.Services;
using BankSystemGui.Models;

namespace BankSystemGui
{
    public partial class Login : Form
    {
        public static string username;
        public static string password;
        private string defaultUserName = "Username";
        private string defaultPassword = "Password";
        public Login()
        {
            InitializeComponent();
            txtUsername.Text = defaultUserName;
            txtUsername.ForeColor = System.Drawing.Color.Gray;
            txtUsername.GotFocus += txtUsername_GotFocus;
            txtUsername.LostFocus += txtUsername_LostFocus;

            txtPassword.Text = defaultPassword;
            txtPassword.ForeColor = System.Drawing.Color.Gray;
            txtPassword.GotFocus += txtPassword_GotFocus;
            txtPassword.LostFocus+= txtPassword_LostFocus;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;
            bool validation = ValidateLogin(username,password);
            

            if (validation)
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
        private void txtUsername_GotFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == defaultUserName)
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtUsername_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = defaultUserName;
                txtUsername.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            if (txtPassword.Text == defaultPassword)
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = defaultPassword;
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
        public static bool ValidateLogin(string username, string password)
        {
            InfoRepository program = new InfoRepository();
            BankServices bank = new BankServices();
            bool validation = bank.ValidateLogin(username, password);
            return validation;
        }
    }
}
