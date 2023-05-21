
using System;
using MySql.Data.MySqlClient;
using BankSystemGui.Models;
using System.Xml.Linq;
using System.Globalization;
using System.Windows.Documents;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BankSystemGui.Repository{
public class InfoRepository
{       
        
        public List<InfoModel> InfoModels{get;set;}
        private MySqlConnection _connection;
        public InfoRepository(){
            string connectionString = "server=istwebclass.org;userid=anewbaue_CatExposure;password=Megumin56;database=anewbaue_Bank";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();
        }
        ~InfoRepository(){
            _connection.Close();
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
        public bool validateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            if (Regex.IsMatch(email, pattern)){
                return true;
            }
            else { return false; }
        }
        public bool validateUserName(string username)
        {
            if(username.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validatePassword(string password)
        {
            if(password.Length >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validatePhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }
        public void registerAccount(string f, string l, string u, string e, string s, string c, int z, string a, string phone, DateTime d,string p)
        {
            var statement = "INSERT INTO bank_client(clientFirstName, clientLastName, clientUserName, clientEmail, clientState, clientCity, clientZipCode, clientAddress," +
                "clientPhoneNumber, clientBirth, clientPassword) VALUES(@newFirst, @newLast, @newUser, @newEmail, @newState, @newCity, @newZip, @newAddress, @newPhoneNumber, " +
                "@newBirth, @newPassword)";
            var command = new MySqlCommand(statement, _connection);
            command.Parameters.AddWithValue("@newFirst",f);
            command.Parameters.AddWithValue("@newLast", l);
            command.Parameters.AddWithValue("@newUser", u);
            command.Parameters.AddWithValue("@newEmail", e);
            command.Parameters.AddWithValue("@newState", s);
            command.Parameters.AddWithValue("@newCity", c);
            command.Parameters.AddWithValue("@newZip", z);
            command.Parameters.AddWithValue("@newAddress", a);
            command.Parameters.AddWithValue("@newPhoneNumber", phone);
            command.Parameters.AddWithValue("@newBirth", d);
            command.Parameters.AddWithValue("@newPassword", p);
            var results = command.ExecuteReader();
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