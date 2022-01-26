using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double Number = Convert.ToDouble(Console.ReadLine());
            if (Number - Math.Round(Number / 2) * 2 == 0)
                Console.WriteLine("Число четное");
            else
            {
                Console.WriteLine("Число нечетное");
            }

            Console.ReadKey();
        }
    }
}
