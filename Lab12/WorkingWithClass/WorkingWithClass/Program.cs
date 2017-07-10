using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro tobi = new Perro();
            tobi.color = "marrón";
            tobi.edad = 15;
            Console.WriteLine("Tobi tiene " + tobi.edad + " años y es de color " + tobi.color);
            tobi.ladra();
            Console.ReadLine();
        }
    }

    class Perro
    {
        public string color;
        public int edad;

        public void ladra()
        {
            Console.WriteLine("Guauu");
        }

        public void duerme()
        {
            Console.WriteLine("Zzzzzz");
        }
    }
}
