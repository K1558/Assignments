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

            // one student
            Student Ella = new Student();
            Ella.Name = "Ella";
            Ella.StudentID = "K1558";
            Ella.Age = 20;
            Ella.Class = "TTV15S1";
            Ella.Courses = "Fysiikka";

            //other student 
            Student Kalle = new Student();
            Kalle.Name = "Kalle";
            Kalle.StudentID = "K2323";
            Kalle.Age = 26;
            Kalle.Class = "TTV15S4";
            Kalle.Courses = "Tietoturvateknologiat";

            //methods 
            Ella.PrintData();
            Console.ReadLine();

            Ella.AddMatikka();
            Ella.PrintData();
            Console.ReadLine();

            Kalle.PrintData();
            Console.ReadLine();

            Kalle.AddOhjelmointi();
            Kalle.PrintData();
            Console.ReadLine();

            Ella.AddOhjelmointi();
            Ella.PrintData();
            Console.ReadLine();

        }
    }
}
