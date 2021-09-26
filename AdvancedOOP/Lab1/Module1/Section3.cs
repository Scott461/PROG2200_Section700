using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Module1 {
    class Section3 {
        static void Main3(string[] args) {
            for (int x = 1; x <= 5; x++) {
               
                for (int i = 1; i <= 20; i++) {
                    if (i >= 11) {
                        Console.WriteLine(11 - (i - 10));
                    } else {
                        Console.WriteLine(i);
                    }
                  
                }
              
            }
        }
    }
}
