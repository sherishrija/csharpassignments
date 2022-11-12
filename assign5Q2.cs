using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment5
{
    internal class assign5Q2


        {
            public static void Main()
            {

                ArrayList Employee = new ArrayList();
                Employee.Add(101);
                Employee.Add("Shrija");
                Employee.Add("Trainee");
                Employee.Add(20000);
                Employee.Add("Banglore");



                foreach (object i in Employee)
                {
                    Console.WriteLine(i + " ");

                }
                Console.ReadLine();



            }
        }
    }

