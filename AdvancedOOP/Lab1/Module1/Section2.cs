using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine();

            switch (code) {
                case "secret":
                    Console.WriteLine("Authenticated");
                    Console.WriteLine("Do you want to enter a new password? Y/N");
                    var answer = Console.ReadLine();
                    if (answer == "Y") {
                        Console.WriteLine("Enter new password");
                        var newPassword = Console.ReadLine();
                        // In reality, you would need to save the user's NEW pw to disc or database 
                    }
                    break;
                default:
                    Console.WriteLine("Not Authenticated");
                    break;
            }

        }
    }
}



