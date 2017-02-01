using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();
            string[] students = new string[4];

            students[0] = student.student_1();
            students[1] = student.student_2();
            students[2] = student.student_3();
            students[3] = student.student_4();

            for (int i = 0; i < students.Length; i++) Console.WriteLine(students[i]);

                  

          

        }
    }
}
