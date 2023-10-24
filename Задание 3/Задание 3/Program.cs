using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное двухзначное число ");
            int a = int.Parse(Console.ReadLine());
            int a1 = a % 10;
            int a2 = (a - a1) / 10;
            Console.WriteLine("Минимальная цифра  {0}", Math.Min(a1,a2));
        }
    }
}
