using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLineIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la nota: ");
            int nota = Convert.ToByte(Console.ReadLine());

            if (nota >= 0 && nota <= 5)
            {
                Console.WriteLine("Estás desaprobado y ya no tienes opciones de aprobar");
            }
            else
            {
                if (nota > 5 && nota <= 10) {
                       Console.WriteLine("Tu nota es mayor que 5 pero menor e igual a 10");
                }
                else
                {
                    if (nota > 10 && nota <= 13) {
                        Console.WriteLine("Estas aprobado pero tu nota es menor o igual a 13");
                    }
                    else
                    {
                        if(nota > 13 && nota <= 16)
                        {
                            Console.WriteLine("Estas aprobado tu nota esta entre 13 y 16");
                        }
                        else
                        {
                            if (nota > 16 && nota <= 20)
                            {
                                Console.WriteLine("Tu nota es satisfactoria, es entre 17 y 20");
                            }
                        }
                    }
                }
                
            }
            Console.ReadKey();
        }
    }
}
