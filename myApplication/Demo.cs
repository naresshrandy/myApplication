using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    class Demo
    {
        public static void Main13()

        {
           List<Employee1> employelist = new List<Employee1>();
            employelist.Add(new Employee1() { Id = 101, Name = "Naresh" , Experience = 5, Salary = 12000});
            employelist.Add(new Employee1() { Id = 101, Name = "Kitti", Experience = 7, Salary = 8000 });
            employelist.Add(new Employee1() { Id = 101, Name = "Ramya", Experience = 6, Salary = 6000 });
            employelist.Add(new Employee1() { Id = 101, Name = "Shanti", Experience = 3, Salary = 3000 });

            Employee1.PromotedEmployee(employelist);
        }
    }
    class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromotedEmployee(List<Employee1> employeelist)
        {
            foreach (Employee1 employee in employeelist)
            {
                if(employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + "Promoted");
                }
            }
        }
    }
}
