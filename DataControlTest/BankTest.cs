namespace DataControlTest;
using BankSystemDataControl.Repository;
using BankSystemDataControl.Models;
using Moq;
using BankSystemDataControl.Services;
using Xunit.Abstractions;
using Xunit;

public class UnitTest1
{
    public InfoRepository _infoRepository;
 


    [Fact]
    public void ValidationLogin_CheckValid()
    {
        _infoRepository = new InfoRepository();
         // Arrange
            string validUsername = "SAMPLE1";
            string validPassword = "SAMPLEPASSWORD";

            // Act
            bool result = _infoRepository.ValidateLogin(validUsername, validPassword);

            // Assert
            Assert.True(result);
    }
    [Fact]
    public void ValidationLogin_CheckInvalid()
    {
        _infoRepository = new InfoRepository();
         // Arrange
            string validUsername = "Failed";
            string validPassword = "Failed";

            // Act
            bool result = _infoRepository.ValidateLogin(validUsername, validPassword);

            // Assert
            Assert.False(result);
    }
    
   [Fact]
   public void checkInfo_NotEmpty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnAll().ToList<InfoModel>();
    Assert.NotEmpty(newList);

   }
    
    /*
   [Fact]
   public void checkInfo_Empty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnAll().ToList<InfoModel>();
    Assert.Empty(newList);

   }
    */
   [Fact]
   public void testLoginList_NotEmpty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnLogin().ToList<InfoModel>();
    Assert.NotEmpty(newList);
   }
   /*
   [Fact]
   public void testLoginList_Empty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnLogin().ToList<InfoModel>();
    Assert.Empty(newList);
   }
   */
    
    [Fact]
    public void testUserInformation_InformationMatches()
    {
        _infoRepository = new InfoRepository();
        string username = "QuangHo";
        List<InfoModel> newList = _infoRepository.userInformation(username).ToList<InfoModel>();
        var mockRepository = GetInfoModel();
        foreach(InfoModel model in newList)
        {
            foreach(InfoModel item in mockRepository)
            {
                Assert.Equal(item.FirstName, model.FirstName);
                Assert.Equal(item.LastName, model.LastName);
                Assert.Equal(item.UserName, model.UserName);
                Assert.Equal(item.Password, model.Password);
                Assert.Equal(item.Email, model.Email);
                Assert.Equal(item.PhoneNumber, model.PhoneNumber);
                Assert.Equal(item.State, model.State);
                Assert.Equal(item.City, model.City);
                Assert.Equal(item.ZipCode, model.ZipCode);
                Assert.Equal(item.Address, model.Address);
                Assert.Equal(item.DateOfBirth, model.DateOfBirth);
            }
            
        }






    }
    private List<InfoModel> GetInfoModel()
    {
        return new List<InfoModel>() {
            new InfoModel()
            {
            ID = 1,
            FirstName = "Quang",
            LastName = "Ho",
            UserName = "QuangHo",
            Password = "Rzkkpur2",
            Email = "QuangHo@gmail.com",
            PhoneNumber = "8438438433",
            State = "South Carolina",
            City = "Myrtle Beach",
            ZipCode = 29579,
            Address = "Somewhereln",
            DateOfBirth = new DateTime(0001, 01, 01)
            }
        };
   
          
     
    }
    
    
}