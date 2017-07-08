using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definir variables
            int number01 = 20;
            int number02 = 40;

            //Realizando suma
            Console.WriteLine("El resultado de la suma es: " + (number01 + number02));

            //Realizando resta
            Console.WriteLine("El resultado de la resta es: " + (number01 - number02));

            //Realizando multiplicación
            Console.WriteLine("El resultado de la multiplicación es: " + (number01 * number02));

            //Realizando división
            Console.WriteLine("El resultado de la división es: " + (number01 / number02));

            //Realizando operación para obtener residuo
            Console.WriteLine("El resultado del residuo de la división es: " + (number01 % number02));

            //Haciendo una pausa y esperando una tecla
            Console.ReadKey();
        }
    }
}
