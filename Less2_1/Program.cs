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

            int NumChek = 4201;
            double Tovar1_Cost = 48;
            double Tovar1_Num = 1;
            double Tovar1_Total = Tovar1_Cost * Tovar1_Num;
            double Tovar2_Cost = 79;
            double Tovar2_Num = 2;
            double Tovar2_Total = Tovar2_Cost * Tovar2_Num;
            double Tovar3_Cost = 450;
            double Tovar3_Num = 0.358;
            double Tovar3_Total = Tovar3_Cost * Tovar3_Num;
            double Tovar4_Cost = 780;
            double Tovar4_Num = 0.475;
            double Tovar4_Total = Tovar4_Cost * Tovar4_Num;
            double All_Total = Tovar1_Total + Tovar2_Total + Tovar3_Total + Tovar4_Total;
            double NDS = 0.2;

            Console.WriteLine("ООО Кактус");
            Console.WriteLine("ЧЕК № " + NumChek);
            Console.WriteLine("Кассир Булыжников");
            Console.WriteLine("1. Булочка с изюмом " + Tovar1_Cost + " X " + Tovar1_Num);
            Console.WriteLine("Стоимость..........." + Tovar1_Total);
            Console.WriteLine("2. Лимонад Тархун " + Tovar2_Cost + " X " + Tovar2_Num);
            Console.WriteLine("Стоимость..........." + Tovar2_Total);
            Console.WriteLine("3. Сыр Гауда " + Tovar3_Cost + " X " + Tovar3_Num);
            Console.WriteLine("Стоимость..........." + Tovar3_Total);
            Console.WriteLine("4. Конфеты Мишка " + Tovar4_Cost + " X " + Tovar4_Num);
            Console.WriteLine("Стоимость..........." + Tovar4_Total);
            Console.WriteLine("ВСЕГО..........." + Math.Round(All_Total, 2));
            Console.WriteLine("В том числе НДС(20%),,..." + Math.Round(All_Total * NDS, 2));

            Console.ReadKey();
        }
    }
}
