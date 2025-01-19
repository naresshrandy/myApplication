using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    internal class Student
    {
        public string name;
        public string rollno;
        public Student(string Receivedname, string Receivedrollno)
        {
            name = Receivedname;
            rollno = Receivedrollno;

        }

        public static void Main6(string[] args)
        {
            Student student = new Student("Naresh", "1234");
            Student student1 = new Student("Pavan", "1231");
            Student student2 = new Student("sams", "1235");
            Console.WriteLine($"{student.name},{student.rollno}");
            Console.WriteLine($"{student1.name},{student1.rollno}");
        }
    }
}
