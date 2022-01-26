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
            Console.WriteLine("Введите минимальную температару");
            var Tmin = Console.ReadLine();
            Console.WriteLine("Введите максимальную температару");
            var Tmax = Console.ReadLine();
            var Tsredn = (Convert.ToDouble(Tmax) + Convert.ToDouble(Tmin)) / 2;
            Console.WriteLine("Средняя температура = " + Tsredn);
            Console.ReadKey();
        }
    }
}
