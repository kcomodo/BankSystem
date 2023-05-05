using MyProjects.Repository;
using MyProjects.Models;
using MyProjects.Services;
namespace MyProject;
class Program
{  
    
        static void Main(string[] args){
        InfoRepository program = new InfoRepository();
        BankServices bank = new BankServices();
        
        
        IEnumerable<InfoModel> list = bank.ReturnInfoName();
        foreach(InfoModel info in list){
                Console.WriteLine(info.ToString());
        }

        /*
        IEnumerable<InfoModel> list = program.ReturnNamesFake();
        Console.WriteLine(list);
        */
        }
       
        
        


}
