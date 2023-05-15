using System.Collections.Generic;
using BankSystemGui.Models;
using BankSystemGui.Repository;
using System.Linq;
using System;

namespace BankSystemGui.Services{
    public class BankServices{
        InfoRepository _repo;
        public BankServices(){
            _repo = new InfoRepository();
        }

        /*User stories for customer:
        1. As a customer, I would like to check my deposits
        2. As a customer, I would like to view my charges
        3. As a customer, I would like to view all of my withdrawals
        4. As a customer, I would like to view my bank information (login information)
        More to be added later.
        */

        public bool ValidateLogin(string username, string password){
            bool infoNames = _repo.ValidateLogin(username,password);
            return infoNames;
        }
        public bool validateEmail(string email)
        {
            bool infoEmail = _repo.validateEmail(email);
            return infoEmail;
        }
        public bool validateUserName(string username)
        {
            bool infoUserName = _repo.validateUserName(username);
            return infoUserName;
        }
        public bool validatePassword(string password)
        {
            bool infoPassword =_repo.validatePassword(password);
            return infoPassword;
        }
        public void registerAccount(string f, string l, string u, string e, string s, string c, int z, string a, string phone, DateTime d, string p)
        {
            _repo.registerAccount(f, l, u, e, s, c, z, a, phone, d,p);
        }
        


    }
}