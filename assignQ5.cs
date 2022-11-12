using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpassignment1
{
    internal class assignQ5
    {
        class Program
        {
            public static void Main()
            {
                double r, per_cir, per_area;
                double PI = 3.14;
                Console.WriteLine("input the radius of the circle");
                r = Convert.ToDouble(Console.ReadLine());
                per_cir = 2 * PI * r;
                Console.WriteLine("perimeter of the circle: {0}", per_cir);
                per_area = PI * r * r;
                Console.WriteLine("area of the circle: {0}", per_area);

                Console.Read();


            }
        }
    }
}
