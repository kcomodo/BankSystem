
using System;
using MyProjects.Models;
namespace MyProjects.Repository{
public class InfoRepository
{
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


        //Create a list that holds all the bank info from each person
        
    }
}