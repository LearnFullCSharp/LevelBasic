using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variables con tipo de datos
            int edad = 35;
            byte calzado = 40;
            string nombre = "Jesús";
            double estatura = 1.67;

            //Imprimiendo cadenas de texto con el contenido de variables
            Console.WriteLine("Tu nombre es: " + nombre);
            Console.WriteLine("Tu edad es: " + edad);
            Console.WriteLine("Tu talla de calzado es: " + calzado);
            Console.WriteLine("Tu estatura es: " + estatura);

            //Esperando una tecla para cerrar la consola
            Console.ReadKey();
        }
    }
}
