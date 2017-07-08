using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Es cierto que tres es igual a tres?: " + (3 == 3));
            Console.WriteLine("Es cierto que tres es diferente que tres?: " + (3 != 3));
            Console.WriteLine("Es cierto que tres es mayor que tres?: " + (3 > 3));
            Console.WriteLine("Es cierto que tres es menor que traes?: " + (3 < 3));
            Console.WriteLine("Es cierto que tres es mayor e igual que tres?: " + (3 >= 3));
            Console.WriteLine("Es cierto que tres es menor igual que tres?: " + (3 <= 3));

            Console.ReadKey();
        }
    }
}
