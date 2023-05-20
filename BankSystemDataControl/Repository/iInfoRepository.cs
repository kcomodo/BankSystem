using BankSystemDataControl.Models;

namespace BankSystemDataControl.Repository
{
    public interface iInfoRepository
    { 
        List<InfoModel> InfoModels { get; set; }

        public IEnumerable<InfoModel> ReturnAll();
        public IEnumerable<InfoModel> ReturnLogin();
        public bool ValidateLogin(string username, string password);
        public IEnumerable<InfoModel> userInformation(string username);
        public InfoModel InsertBankInfo(InfoModel info);
        public void UpdateUserInfo(string username, InfoModel info);
        public void DeleteUserInfo(string username);
    }
}
