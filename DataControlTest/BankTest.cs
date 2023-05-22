namespace DataControlTest;
using BankSystemDataControl.Repository;
using BankSystemDataControl.Models;
using Moq;

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
   [Fact]
   public void checkInfo_Empty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnAll().ToList<InfoModel>();
    Assert.Empty(newList);

   }
   [Fact]
   public void testLoginList_NotEmpty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnLogin().ToList<InfoModel>();
    Assert.NotEmpty(newList);
   }
   [Fact]
   public void testLoginList_Empty(){
    _infoRepository = new InfoRepository();
    List<InfoModel> newList = _infoRepository.ReturnLogin().ToList<InfoModel>();
    Assert.Empty(newList);
   }
    [Fact]
    public void testUserInformation_InformationMatches()
    {
        _infoRepository = new InfoRepository();
        var mockRepository = new Mock<InfoRepository>();
        mockRepository.Setup(m => m.InfoModels).Returns(new List<InfoModel>
        {
            new InfoModel()
            {
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
                DateOfBirth = new DateTime(2011, 04, 05)
            }
        });
        
       


    }
    
}