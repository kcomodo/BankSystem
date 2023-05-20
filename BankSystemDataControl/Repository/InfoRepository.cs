using System;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Globalization;
using BankSystemDataControl.Models;
//Data access layer
namespace BankSystemDataControl.Repository
{
    public interface IOperationSingleton : iInfoRepository { }
    public class InfoRepository : iInfoRepository, IOperationSingleton
    {

        public List<InfoModel> InfoModels { get; set; }
        private MySqlConnection _connection;
        public InfoRepository()
        {
            string connectionString = "server=istwebclass.org;userid=anewbaue_CatExposure;password=Megumin56;database=anewbaue_Bank";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        ~InfoRepository()
        {
            _connection.Close();
        }
       

        public IEnumerable<InfoModel> ReturnAll()
        {
            var statement = "Select * from bank_client";
            var command = new MySqlCommand(statement, _connection);
            var results = command.ExecuteReader();
            List<InfoModel> newList = new List<InfoModel>();

            while (results.Read())
            {

                InfoModel i = new InfoModel()
                {
                    ID = (int)results[0],
                    FirstName = (string)results[1],
                    LastName = (string)results[2],
                    UserName = (string)results[3],
                    Email = (string)results[4],
                    State = (string)results[5],
                    City = (string)results[6],
                    ZipCode = (int)results[7],
                    Address = (string)results[8],
                    PhoneNumber = (string)results[9],
                    DateOfBirth = DateTime.ParseExact(results.GetString(10), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                    Password = (string)results[11]

                };


                newList.Add(i);

            }
            results.Close();
            return newList;
        }
        
        public IEnumerable<InfoModel> ReturnLogin()
        {
            var statement = "Select clientUserName, clientPassword from bank_client";
            var command = new MySqlCommand(statement, _connection);
            var results = command.ExecuteReader();
            List<InfoModel> newList = new List<InfoModel>();

            while (results.Read())
            {

                InfoModel i = new InfoModel()
                {
                    UserName = (string)results[0],
                    Password = (string)results[1]

                };


                newList.Add(i);

            }
            results.Close();
            return newList;
        }
        
        public bool ValidateLogin(string username, string password)
        {
            var statement = "Select clientUserName, clientPassword from bank_client";
            var command = new MySqlCommand(statement, _connection);
            var results = command.ExecuteReader();

            while (results.Read())
            {
                if (username.Equals(results[0]) && password.Equals(results[1]))
                {
                    return true;
                }

            }

            results.Close();
            return false;
        }
        public IEnumerable<InfoModel> userInformation(string username)
        {
            var statement = "Select * from bank_client where clientUserName=@newUserName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newUserName", username);
            var results = command.ExecuteReader();
            List<InfoModel> newList = new List<InfoModel>();
            while (results.Read())
            {
                InfoModel i = new InfoModel
                {
                    ID = (int)results[0],
                    FirstName = (string)results[1],
                    LastName = (string)results[2],
                    UserName = (string)results[3],
                    Email = (string)results[4],
                    State = (string)results[5],
                    City = (string)results[6],
                    ZipCode = (int)results[7],
                    Address = (string)results[8],
                    PhoneNumber = (string)results[9],
                    DateOfBirth = DateTime.ParseExact(results.GetString(10), "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                    Password = (string)results[11]
                };
                newList.Add(i);
               
            }
            results.Close();
            return newList;
        }
        public InfoModel InsertBankInfo(InfoModel info)
        {
            var statement = "Insert into bank_client(clientFirstName, clientLastName, clientUserName, clientEmail, clientState, clientCity, clientZipCode, clientAddress, clientPhoneNumber, " +
                "clientBirth, clientPassword) VALUES (@newFirst, @newLast, @newUser, @newEmail, @newState, @newCity, @newZip, @newAddress, @newPhone, @newBirth, @newPassword)";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newFirst", info.FirstName);
            command.Parameters.AddWithValue("@newLast", info.LastName);
            command.Parameters.AddWithValue("@newUser", info.UserName);
            command.Parameters.AddWithValue("@newEmail", info.Email);
            command.Parameters.AddWithValue("@newState", info.State);
            command.Parameters.AddWithValue("@newCity", info.City);
            command.Parameters.AddWithValue("@newZip", info.ZipCode);
            command.Parameters.AddWithValue("@newAddress", info.Address);
            command.Parameters.AddWithValue("@newPhone", info.PhoneNumber);
            command.Parameters.AddWithValue("@newBirth", info.DateOfBirth);
            command.Parameters.AddWithValue("@newPassword", info.Password);

            command.ExecuteNonQuery();
            return info;


        }
        public void UpdateUserInfo(string username, InfoModel info)
        {
            var statement = "Update bank_set set clientFirstName=@newFirst, clientLastName=@newLast, clientUserName=@newUser, clientEmail=@newEmail, clientState=@newState, clientCity=@newCity, clientZipCode=@newZip, " +
                "clientAddress=@newAddress, clientPhoneNumber=@newPhone, clientBirth=@newBirth, clientPassword=@newPassword Where clientUserName = @currentUserName";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newFirst", info.FirstName);
            command.Parameters.AddWithValue("@newLast", info.LastName);
            command.Parameters.AddWithValue("@newUser", info.UserName);
            command.Parameters.AddWithValue("@newEmail", info.Email);
            command.Parameters.AddWithValue("@newState", info.State);
            command.Parameters.AddWithValue("@newCity", info.City);
            command.Parameters.AddWithValue("@newZip", info.ZipCode);
            command.Parameters.AddWithValue("@newAddress", info.Address);
            command.Parameters.AddWithValue("@newPhone", info.PhoneNumber);
            command.Parameters.AddWithValue("@newBirth", info.DateOfBirth);
            command.Parameters.AddWithValue("@newPassword", info.Password);
            command.Parameters.AddWithValue("@currentUserName", username);

            int result = command.ExecuteNonQuery();
        }
        public void DeleteUserInfo(string username)
        {
                var statement = "DELETE FROM bank_client WHERE clientUserName=@Username";
                var command = new MySqlCommand(statement, _connection);
                command.Parameters.AddWithValue("@Username", username);
                command.ExecuteNonQuery();
        }
        


    }


}
/*
      public List<InfoModel> info {get;set;}
      InfoModel infoclass = new InfoModel(){
          ID = 12356,
          Name = "Bob",
          DateOfBirth = "10/3/1999",
          Address = "123 Somewhere downtown"

      };
      InfoModel infoclass2 = new InfoModel(){
          ID = 00000,
          Name = "Quang",
          DateOfBirth = "12/2/2000",
          Address = "123 Somewhere Uptown"

      };
      InfoModel infoclass3 = new InfoModel(){
          ID = 99999,
          Name = "Rick",
          DateOfBirth = "7/5/1987",
          Address = "123 Somewhere downtown"

      };
      */

//Create a list that holds all the bank info from each person