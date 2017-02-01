using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht5
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentID { get; set; }
        public string Class { get; set; }
        public string Courses { get; set; }

        // hbd

        public void Hbd()
        {
            Age++;
        }

        //dropping out 

        public void Dropping()
        {
            Class = "Dropping out";
        }
        
        public void AddMatikka()
        {
            string str = Convert.ToString(Courses + ", Matematiikka");
            Courses = str;
            
        }

        public void AddOhjelmointi()
        {
            string s = Convert.ToString(Courses + ", Ohjelmointi");
            Courses = s;
        }


        public void PrintData()
        {
            Console.WriteLine("Student's name: "+Name+ " Age: " +Age+ " Student-ID: "+StudentID+ " Class: " +Class);
            Console.WriteLine("Student is taking classes: "+Courses);
        }

    }
}
