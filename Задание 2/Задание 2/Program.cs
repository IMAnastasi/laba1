using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1 = ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            float y1 = float.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            float y2 = float.Parse(Console.ReadLine());
            double ab =Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Расстояние между точками равно + {0}", ab);
        }
    }
}
