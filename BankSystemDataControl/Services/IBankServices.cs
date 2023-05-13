using BankSystemDataControl.Models;
//Interface for bankservice
namespace BankSystemDataControl.Services
{
    public interface IBankServices
    {
        //public List<InfoModel> ReturnAll();
        public List<InfoModel> ReturnLogin();
        public bool ValidateLogin(string username, string password);
    }
}
