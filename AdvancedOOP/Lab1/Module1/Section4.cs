using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab1.Module1 {
    class Section4 {

        static void Main(string[] args) {
            Console.WriteLine("How many students in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var students = new string[studentCount, 2];

            for (int i = 0; i < studentCount; i++) {
                Console.Write("Student Name: ");
                var studentName = Console.ReadLine();

                Console.Write("Student Grade: ");
                var studentGrade = (Console.ReadLine());

                students[i, 0] = studentName;
                students[i, 1] = studentGrade;

            }

            for (int i = 0; i < studentCount; i++) {
                Console.WriteLine("Name: {0}, Grade: {1}", students[i,0], students[i,1]);
            }
        }
    }
}
