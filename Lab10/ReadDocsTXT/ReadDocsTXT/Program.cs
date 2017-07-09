using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadDocsTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este código debe ir acompañado con el proyecto de crear documentos TXT
            TextReader texto2 = new StreamReader("prueba.txt"); //Abre el archivo de texto
            Console.WriteLine(texto2.ReadLine()); //Imprime en consola el contenido del archivo de texto
            texto2.Close(); //Cerrar el documento

            Console.ReadLine(); //Esperar una tecla para cerrar la ventana de consola
        }
    }
}
