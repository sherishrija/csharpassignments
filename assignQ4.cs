using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment1
{
    internal class assignQ4
    {
        class Program
        {
            static void Main(string[] args)
            {
                int num1, num2, temp;
                Console.WriteLine("Enter the number for num1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the number for num2");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Before swapping num1 = {0} and num2 = {1}", num1, num2);

                temp = num1;
                num1 = num2;
                num2 = temp;

                Console.WriteLine("After swapping num1 = {0} and num2 = {1}", num1, num2);

            }

        }
    }
}

