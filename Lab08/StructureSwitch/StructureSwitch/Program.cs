using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de día: ");
            byte numdias = Convert.ToByte(Console.ReadLine());

            switch (numdias)
            {
                case 1:
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case 2:
                    Console.WriteLine("Hoy es Martes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es Miércoles");
                    break;
                //case 4: 
                //    Console.WriteLine("Hoy es Jueves");
                case 5:
                    Console.WriteLine("Hoy es Viernes");
                    break;
                case 6:
                    Console.WriteLine("Hoy es Sábado");
                    break;
                case 7:
                    Console.WriteLine("Hoy es Domingo");
                    break;
                //default:
                //    Console.WriteLine("Haz ingresado un número incorrecto");
            }

            Console.ReadKey();
        }
    }
}
