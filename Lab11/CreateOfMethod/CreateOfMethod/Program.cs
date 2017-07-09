using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateOfMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            mimetodo("Jesús");
            mimetodo("Jaime");
            mimetodo("Jorge", "25");
            Console.ReadKey();
        }

        static void mimetodo(string nombre)
        {
            Console.WriteLine("Escribo texto desde el método, el nombre es: " + nombre);
        }

        static void mimetodo(string nombre, string edad)
        {
            Console.WriteLine("Escribo texto desde el método, el nombre es: " + nombre + " y mi edad es " + edad + " años.");
        }
    }
}
