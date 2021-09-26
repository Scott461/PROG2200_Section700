using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2 {
    class Program {
        static void Main2(string[] args) {
            Console.WriteLine("What is the pass code?");
            var code = Console.ReadLine();

            if (code == "secret") {
                Console.WriteLine("Authenticated");
                Console.WriteLine("Do you want to enter a new password? Y/N");
                var answer = Console.ReadLine();
                if (answer == "Y") {
                    Console.WriteLine("Enter new password");
                    var newPassword = Console.ReadLine();
                    // In reality, you would need to save the user's NEW pw to disc or database 
                } 
            } else if (code != "secret") {
                Console.WriteLine("Not Authenticated");
            }

        }
    }
}


