using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum MonthString

{
    Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь
}


namespace Less2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Введите номер месяца");
            int Month = Convert.ToInt32(Console.ReadLine());

            switch (Month - 1)
            {
                case (int)MonthString.Январь:
                    Console.WriteLine(MonthString.Январь);
                    break;
                case (int)MonthString.Февраль:
                    Console.WriteLine(MonthString.Февраль);
                    break;
                case (int)MonthString.Март:
                    Console.WriteLine(MonthString.Март);
                    break;
                case (int)MonthString.Апрель:
                    Console.WriteLine(MonthString.Май);
                    break;
                case (int)MonthString.Май:
                    Console.WriteLine(MonthString.Январь);
                    break;
                case (int)MonthString.Июнь:
                    Console.WriteLine(MonthString.Июнь);
                    break;
                case (int)MonthString.Июль:
                    Console.WriteLine(MonthString.Июль);
                    break;
                case (int)MonthString.Август:
                    Console.WriteLine(MonthString.Август);
                    break;
                case (int)MonthString.Сентябрь:
                    Console.WriteLine(MonthString.Сентябрь);
                    break;
                case (int)MonthString.Октябрь:
                    Console.WriteLine(MonthString.Октябрь);
                    break;
                case (int)MonthString.Ноябрь:
                    Console.WriteLine(MonthString.Ноябрь);
                    break;
                case (int)MonthString.Декабрь:
                    Console.WriteLine(MonthString.Декабрь);
                    break;
            }

            Console.ReadKey();

        }
    }
}
