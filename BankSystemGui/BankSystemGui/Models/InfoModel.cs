using System;
namespace BankSystemGui.Models
{
public class InfoModel
{
        public int ID{get;set;} //Default getter setters
        public string FirstName{get;set;}
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string State {get; set;}
        public string City { get; set; }
        public int ZipCode { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString(){ //Override method ToString to print out specific information
            return $"ID: {ID} \nFirst Name: {FirstName} \nlast Name: {LastName} \nUser Name: {UserName} \nPassword: {Password} \nDate Of Birth: {DateOfBirth} \nAddress: {Address}" +
                $"\nEmail: {Email} \nPhone Number: {PhoneNumber} \nState: {State} \nCity: {City} \nZip Code: {ZipCode} \nAddress: {Address}";
        }
       
    }
}