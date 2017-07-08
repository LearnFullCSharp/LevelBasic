using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAndOr
{
    class Program
    {
        static void Main(string[] args)
        {

            //Operador And
            Console.WriteLine("Es cierto que: " + (3 == 3 && 4 == 4));
            Console.WriteLine("Es cierto que: " + (3 == 3 && 4 == 5));

            //Operador Or
            Console.WriteLine("Es cierto que: " + (3 == 3 || 4 == 6));
            Console.WriteLine("Es cierto que: " + (3 > 1 || 2 == 2));
            Console.ReadKey();
        }
    }
}
