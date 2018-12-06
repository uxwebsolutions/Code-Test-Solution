using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APITest.BusinessLogic;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserLogic logic = new UserLogic();
            var user = logic.GetUser().Name;
            var role = logic.GetUser().UserRole.Name;
          
            System.Console.WriteLine(" Hello " + user);
            System.Console.WriteLine(" Your role is  " + role);

            Console.ReadKey();
            
        }
    }
}
