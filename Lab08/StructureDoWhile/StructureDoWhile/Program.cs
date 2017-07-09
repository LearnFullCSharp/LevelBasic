using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            do {
                Console.WriteLine("Este es el numero de vez que pasas por aqui: " + contador);
            } while (contador < 10);
            Console.ReadLine();
        }
    }
}
