using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less2_1
{
    internal class Program
    {

        [Flags]
        public enum Nedel
        {
            Ned1 = 0b_0000001,
            Ned2 = 0b_0000010,
            Ned3 = 0b_0000100,
            Ned4 = 0b_0001000,
            Ned5 = 0b_0010000,
            Ned6 = 0b_0100000,
            Ned7 = 0b_1000000,
        }

        static void Main(string[] args)
        {

            Nedel Office1 = Nedel.Ned1 | Nedel.Ned2 | Nedel.Ned3 | Nedel.Ned4 | Nedel.Ned5;
            Nedel Office2 = Nedel.Ned1 | Nedel.Ned2 | Nedel.Ned3 | Nedel.Ned4 | Nedel.Ned5 | Nedel.Ned6 | Nedel.Ned7 ;

            Console.WriteLine(Office1);
            Console.WriteLine(Office2);
            Console.ReadKey();
        }
    }
}
