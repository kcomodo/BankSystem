namespace DataControlTest;
using BankSystemDataControl.Repository;
using BankSystemDataControl.Models;
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
    
}