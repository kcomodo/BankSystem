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
            command.Parameters.AddWithValue("username", username);
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
            return newList;
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