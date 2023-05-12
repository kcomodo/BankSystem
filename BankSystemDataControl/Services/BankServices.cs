using System.Collections.Generic;
using MyProjects.Models;
using MyProjects.Repository;
using System.Linq;
namespace MyProjects.Services
{
    public class BankServices
    {
        InfoRepository _repo;
        public BankServices()
        {
            _repo = new InfoRepository();
        }

        /*
        User stories for admin:
        1. As an admin, I would like to view only the names of the customers
        2. As an admin, I would like to view all of the information of every customer.
        3. As an admin, I would like to add new users
        4. As an admin, I would like to delete previous users
        5. As an admin, I would like to edit users
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
        public bool ValidateLogin(string username, string password)
        {
            bool infoNames = _repo.ValidateLogin(username, password);
            return infoNames;
        }

    }
}