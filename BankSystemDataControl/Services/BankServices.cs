using System.Collections.Generic;
using MyProjects.Models;
using MyProjects.Repository;
using System.Linq;
namespace MyProjects.Services{
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
        -----------------------------------------------------------------------------------
        User stories for admin:
        1. As an admin, I would like to view only the names of the customers
        2. As an admin, I would like to view all of the information of every customer.
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