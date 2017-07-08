using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorIf
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 55;
            if (edad < 30) {
                //Código si es cierto
                Console.WriteLine("Mensaje de verdad");
                Console.ReadKey();
            }
            else {
                //Código si es falso
                Console.WriteLine("Mensaje de falsedad");
                Console.ReadKey();
            };
        }
    }
}
