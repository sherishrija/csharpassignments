using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment5
{
    internal class Employee
    
        {
            public int Eid { get; set; }
            public string EName { get; set; }
            public string Erole { get; set; }
            public int Salary { get; set; }
            public string Location { get; set; }

        }
        public class EmployeeDetails
        {
            public static void Main()
            {
                List<Employee> Employees = new List<Employee>();
                Employees.Add(new Employee
                {
                    Eid = 101,
                    EName = "Shrija",
                    Erole = "Trainee",
                    Location = "Bangalore",
                    Salary = 20000
                });
                Employees.Add(new Employee
                {
                    Eid = 102,
                    EName = "Keerthana",
                    Erole = "Trainee",
                    Location = "Banglore",
                    Salary = 20000
                });
                Employees.Add(new Employee
                {
                    Eid = 103,
                    EName = "Amrutha",
                    Erole = "Trainee",
                    Location = "Hyderabad",
                    Salary = 20000
                });


                foreach (Employee e in Employees)
                {
                    Console.WriteLine(e.Eid + " " + e.EName + " " + e.Erole + " " + e.Location + " " + e.Salary);
                }
                Console.ReadLine();

                Console.WriteLine("Total no.of Employees:");
                Console.WriteLine(Employees.Count());
                Console.ReadLine();

                Employee E = Employees.Find(emp => emp.EName.StartsWith("P"));
                Console.WriteLine("Eid = {0}", E.Eid);
                Console.ReadLine();





            }
        }
    }

