// See https://aka.ms/new-console-template for more information
using MyProjects.Repository;
using MyProjects.Models;
namespace MyProject{
    class Program{
        static void Main(string[] args){
            private InfoRepository repo = new InfoRepository();
            
            public List<InfoModel> ReturnInfo(){
                List<InfoModel> allInfo = repo.info;
                return allInfo;
            }
        
        }
    }
}