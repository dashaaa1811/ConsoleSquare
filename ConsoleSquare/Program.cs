using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите число");
                int num=int.Parse(Console.ReadLine());
            Console.WriteLine(Square(num));
        }
        static int Square(int a)
        {
            int s = a * a;
            return s;
        }
    }
}
