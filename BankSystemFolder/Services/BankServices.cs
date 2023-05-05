using System.Collections.Generic;
using MyProjects.Models;
using MyProjects.Repository;
using System.Linq;
namespace MyProjects.Services{
    public class BankServices{
        InfoRepository _repo;
        public List<InfoModel> ReturnInfoName(){
            List<InfoModel> infoNames = _repo.ReturnName().ToList<InfoModel>();
            return infoNames;
        }
        public List<InfoModel> returnFake(){
            List<InfoModel> returnFakeInfo = _repo.ReturnNamesFake().ToList<InfoModel>();
            return returnFakeInfo;
        }
    }
}