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

        /*User stories:
        1. As a customer, I would like to check my deposits
        2. As a customer, I would like to view my charges
        3. As a customer, I would like to view all of my withdrawals
        More to be added later.
          
        */
        public List<InfoModel> ReturnInfoName(){
            List<InfoModel> infoNames = _repo.ReturnName().ToList<InfoModel>();
            return infoNames;
        }
    }
}