using System.Collections.Generic;
using BankSystemDataControl.Models;
using BankSystemDataControl.Repository;
using System.Linq;
namespace BankSystemDataControl.Services
{
    public class BankServices : IBankServices
    {
        iInfoRepository _repo;
        public BankServices(iInfoRepository bankRepo)
        {
            _repo = bankRepo;
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
            if(newList != null)
            {
                return newList;
            }
            return null;
            
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
        public List<InfoModel> userInformation(string username)
        {
          List<InfoModel> newList = _repo.userInformation(username).ToList<InfoModel>();
            return newList;

        }
        public InfoModel InsertBankInfo(InfoModel info)
        {
            return _repo.InsertBankInfo(info);
            
        }
        public void DeleteUserInfo(string username)
        {
            _repo.DeleteUserInfo(username);
        }



    }
}