using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChatLib;

namespace SimpleChat {
    class Program {
        static void Main(string[] args) 
            {
            /* ------------------------ Part 1 ----------------------------------------
            // Run as Client vs Server
            Console.WriteLine("Listening for messages");

            // User Input Mode. Once hitting "I" key 
            // Console.ReadLine();
            var userKey = Console.ReadKey();



            // Display incoming message


            // Allow for input 

            // Let the user quit 
            // Console.WriteLine($"You typed {userKey}");
            Console.WriteLine($"You typed {userKey.Key}");
            Console.Beep(); 
            ------------------------ Part 1 ---------------------------------------- */

            /* ----------------------Part 2 ---------------------------------------- */
            // Run as Client vs Server
            //while (true) 
            //{
            //    Console.WriteLine("Listening for messages");

            //    // User Input Mode. Once hitting "I" key 
            //    ConsoleKeyInfo userKey = Console.ReadKey(); // Blocking statement 

            //    // Allow for input 

            //    // Let the user quit 
            //    // Console.WriteLine($"You typed {userKey}");
            //    Console.WriteLine($"You typed {userKey.Key}");
            //}

            /* ----------------------Part 3 ---------------------------------------- */

            //// Run as Client vs Server
            //while (true) 
            //{

            //    Console.WriteLine("Listening for messages");
            //    if (Console.KeyAvailable) 
            //    {
            //        // User Input Mode. Once hitting "I" key 
            //        ConsoleKeyInfo userKey = Console.ReadKey(); // Blocking statement 

            //        // Allow for input 

            //        // Let the user quit 
            //        // Console.WriteLine($"You typed {userKey}");
            //        Console.WriteLine($"You typed {userKey.Key}");
            //        Thread.Sleep(500);
            //    }

            //}

            ///* ---------------------- Part 4 ---------------------------------------- */

            //// Run as Client vs Server
            //while (true) {

            //    Console.WriteLine("Listening for messages");
            //    if (Console.KeyAvailable) {
            //        // User Input Mode. Once hitting "I" key 
            //        ConsoleKeyInfo userKey = Console.ReadKey(); // Blocking statement 
            //        if (userKey.Key == ConsoleKey.I) 
            //        {
            //            Console.WriteLine("I is PRESSED >>");
            //            Console.ReadLine();
            //            // break;
            //        }
            //        else 
            //        {
            //            Console.WriteLine($"You typed {userKey.Key}");
            //            Thread.Sleep(500);

            //        }
            //        // Allow for input 

            //        // Let the user quit 
            //        // Console.WriteLine($"You typed {userKey}");

            //    }

            //}

            /* ---------------------- Part 5 -6 ---------------------------------------- */
            //Console.WriteLine(args[0]);
            if (args.Contains("-server")) // args[0} = "-server"
            {
                Console.WriteLine("Server");
                Server server = new Server(); // new object 

            } else 
            {
                Console.WriteLine("Client");
                Client client = new Client(); // new object
            }
            Console.ReadLine(); // Blocking statement

            // Run as Client vs Server
            while (true) {

                Console.WriteLine("Listening for messages");
                if (Console.KeyAvailable) {
                    // User Input Mode. Once hitting "I" key 
                    ConsoleKeyInfo userKey = Console.ReadKey(); // Blocking statement 
                    if (userKey.Key == ConsoleKey.I) {
                        Console.WriteLine("I is PRESSED >>");
                        Console.ReadLine();
                        // break;
                    } else {
                        Console.WriteLine($"You typed {userKey.Key}");
                        Thread.Sleep(500);

                    }
                    // Allow for input 

                    // Let the user quit 
                    // Console.WriteLine($"You typed {userKey}");

                }

            }

        }
    }
}
