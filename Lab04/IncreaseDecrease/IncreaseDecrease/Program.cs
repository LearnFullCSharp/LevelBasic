using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseDecrease
{
    class Program
    {
        static void Main(string[] args)
        {
            int aumentar = 1;
            Console.WriteLine("El valor del contador es: " + aumentar);
            aumentar ++;
            Console.WriteLine("Nuevo valor del contador es: " + aumentar);

            aumentar *= 2;
            Console.WriteLine("Aumentar por 2: " + aumentar);

            double disminuir = 6;
            Console.WriteLine("El valor del descontador es: " + disminuir);
            disminuir--;
            Console.WriteLine("El nuevo valor de descontador es: " + disminuir);

            disminuir /= 2;
            Console.WriteLine("El valor resultado de la división es: " + disminuir);

            Console.ReadKey();
        }
    }
}
