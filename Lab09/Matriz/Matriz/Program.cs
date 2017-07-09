using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombre = new string[100];
            nombre[0] = "José";
            nombre[1] = "Juan";
            nombre[2] = "Jorge";
            nombre[3] = "Julian";
            nombre[4] = "Javier";
            nombre[5] = "Jaime";

            for (int elementomatriz = 0; elementomatriz < 10; elementomatriz++) {
                Console.WriteLine(nombre[elementomatriz]);
            }
            Console.ReadKey();
        }
    }
}
