
using System;
using MySql.Data.MySqlClient;
using BankSystemGui.Models;
using System.Xml.Linq;
using System.Globalization;
using System.Windows.Documents;
using System.Collections.Generic;

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
        /*
        public InfoModel registerAccount()
        {

        }
        */

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