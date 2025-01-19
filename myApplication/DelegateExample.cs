using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApplication
{
    class DelegateExample
    {
        public static void Main14()
        {
            List<Employee> employees = new List<Employee>();
            
                employees.Add(new Employee() { Id = 101, Name = "Naresh", Experience = 5, Salary = 1200 });
                employees.Add(new Employee() { Id = 102, Name = "Kitti", Experience = 6, Salary = 1200 });
                employees.Add(new Employee() { Id = 103, Name = "Ramya", Experience = 4, Salary = 1100 });
                employees.Add(new Employee() { Id = 104, Name = "Shanti", Experience = 2, Salary = 200 });

           
                Employee.IsPromotable(employees, prom => prom.Experience >=5);
            

        } 
        /*public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }*/
    }
    delegate bool Promoted(Employee employee);
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void IsPromotable(List<Employee> employeelist, Promoted promoted)
        {
            foreach (Employee employe in employeelist)
            {
                if(promoted(employe))
                {
                    Console.WriteLine("this employee is Promoted:" + employe.Name);
                }
            }
        }
    }
}
