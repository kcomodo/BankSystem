using System;
namespace MyProjects.Models
{
public class InfoModel
{
        public int ID{get;set;} //Default getter setters
        public string Name{get;set;}
        public string DateOfBirth{get;set;}

        public string Address{get;set;}

        public override string ToString(){ //Override method ToString to print out specific information
            return $"ID: {ID} \nName: {Name} \nDate Of Birth: {DateOfBirth} \nAddress: {Address}";
        }
    }
}