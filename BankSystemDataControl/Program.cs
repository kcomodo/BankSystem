using MyProjects.Repository;
using MyProjects.Models;
using MyProjects.Services;

namespace MyProjects;
class Program
{
    public  static string name;

    static void Main(string[] args){
        InfoRepository program = new InfoRepository();
        BankServices bank = new BankServices();

        /*
        NOTE: Branch out when creating a service function for the user story
        User stories are in the bankservices.cs
        TODO:
        Create login for username and password, and other info.
        Create username and password validation
        Save info in database
        Assign ID to account created
        Check login to see if it's valid
        -----------------------------------------------------------
        LATER ON: 
        Unit test user story that have been created.
        .NET Webservice to modify and add data, rather than manually changing from sql
        Banking website
        
        */
        DisplayUserName(name);
        /*
        IEnumerable<InfoModel> list = bank.ReturnInfoName();
        foreach (InfoModel info in list)
        {
            Console.WriteLine(info.Name);
        }
        */
        }

    public static string DisplayUserName(string name)
    {
        InfoRepository program = new InfoRepository();
        BankServices bank = new BankServices();
        string newName = bank.ReturnInfoName(name);
        return newName;
    }
}
