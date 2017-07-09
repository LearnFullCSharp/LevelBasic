using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (contador <20 )
            {
                Console.WriteLine("Este es el número: " + contador);
                contador++;
            }
            Console.ReadLine();
        }
    }
}
