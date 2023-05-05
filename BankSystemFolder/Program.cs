using MyProjects.Repository;
using MyProjects.Models;
using MyProjects.Services;
namespace MyProject;
class Program
{  
    
        static void Main(string[] args){
        InfoRepository program = new InfoRepository();
        
        IEnumerable<InfoModel> list = program.ReturnName();
        Console.WriteLine(list);

        /*
        IEnumerable<InfoModel> list = program.ReturnNamesFake();
        Console.WriteLine(list);
        */
        }
       
        
        


}
