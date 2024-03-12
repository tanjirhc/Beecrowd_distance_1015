using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_distance_1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance, x, y;

            String p1 = Console.ReadLine();
            String p2 = Console.ReadLine();

            string[] i = p1.Split(' ');
            string[] j = p2.Split(' ');

            double x1 = double.Parse(i[0]);
            double y1 = double.Parse(i[1]);
            double x2 = double.Parse(j[0]);
            double y2 = double.Parse(j[1]);


            distance = Math.Sqrt(Math.Pow(x = (x2 - x1), 2) + Math.Pow(y = (y2 - y1), 2));

            Console.WriteLine("{0:0.0000}", distance);
            Console.ReadKey();
        }
    }
}
