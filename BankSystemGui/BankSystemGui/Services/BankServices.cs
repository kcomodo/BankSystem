using System.Collections.Generic;
using BankSystemGui.Models;
using BankSystemGui.Repository;
using System.Linq;
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
        public List<InfoModel> ReturnAll()
        {
            List<InfoModel> newList = _repo.ReturnAll().ToList<InfoModel>();
            return newList;
        }
        public List<InfoModel> ReturnLogin()
        {
            List<InfoModel> newList = _repo.ReturnLogin().ToList<InfoModel>();
            return newList;
        }
        public bool ValidateLogin(string username, string password){
            bool infoNames = _repo.ValidateLogin(username,password);
            return infoNames;
        }
        
    }
}