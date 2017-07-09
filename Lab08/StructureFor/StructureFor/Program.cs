using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Acumulador
            for (int contador = 1; contador <= 10; contador += 2)
            {
                Console.WriteLine("Mensaje de prueba " + contador + " este es el número final");
            }

            //Cuenta regresiva
            for (int disminuir = 10; disminuir >0; disminuir--)
            {
                Console.WriteLine("Mensaje de prueba " + disminuir + " este es el número final");
            }

            Console.ReadLine();
        }
    }
}
