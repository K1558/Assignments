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
        public string student_1 ()
        {
            Name = "Ella";
            StudentID = "K1558";
            Age = 20;
            Class = "TTV15S1";
            Courses = "Fysiikka";
            return String.Format("Student's name: " + Name + " Age: " + Age + " Student-ID: " + StudentID + " Class: " + Class);

        }
        public string student_2 ()
        {
            Name = "Kalle";
            StudentID = "K2323";
            Age = 26;
            Class = "TTV15S4";
            Courses = "Tietoturvateknologiat";
            return String.Format("Student's name: " + Name + " Age: " + Age + " Student-ID: " + StudentID + " Class: " + Class + ", Is taking courses: " +Courses);

        }

        public string student_3()
        {
            Name = "Juuso";
            Age = 22;
            Class = "TTV16S3";
            StudentID = "K2222";
            Courses = "Englanti";
            return String.Format("Student's name: " + Name + " Age: " + Age + " Student-ID: " + StudentID + " Class: " + Class + ", Is taking courses: " + Courses);

        }

        public string student_4()
        {
            Name = "Nimi";
            Age = 0;
            Class = "joku luokka";
            StudentID = "joku id";
            Courses = "joku kurssi";
            return String.Format("Student's name: " + Name + " Age: " + Age + " Student-ID: " + StudentID + " Class: " + Class + ", Is taking courses: " + Courses);

        }
       


        

    }
}
