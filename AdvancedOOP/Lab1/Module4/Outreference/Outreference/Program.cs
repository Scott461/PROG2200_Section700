using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;namespace outreference {
    class Program {
        static void Main(string[] args) {
            //int test = 2; 
            //Console.WriteLine(test); 
            //Five(out test); //Console.WriteLine(test); 
            //Double(ref test); 
            //Console.WriteLine(test); 
            //Console.ReadLine(); 
            var test = "1.5";
            //test code 
            var outDouble = 0.0; 
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble)); 
            Console.WriteLine("Test type is {0}", outDouble.GetType()); 
            test = "Ronan"; 
            outDouble = 0.0; 
            Console.WriteLine("Result: {0}", ParseDouble(test, out outDouble)); 
            Console.WriteLine("Test value is {0}", outDouble); 
            Console.ReadLine();//pause to read
        }
        static void Five(out int input)//sets the input to 5
      {
            input = 5;
        }
        static void Double(ref int input)//doubles the input
      {
            input *= 2;
        }
        static Boolean ParseDouble(string input, out double outDouble)//function that determines if a string is double-parsable
      {
            try {
                outDouble = double.Parse(input);//attempt to parse, return true if successful
                return true;
            } catch (Exception) {
                outDouble = 0;
                return false;//return false if an exception is thrown
            }
        }
    }
}
