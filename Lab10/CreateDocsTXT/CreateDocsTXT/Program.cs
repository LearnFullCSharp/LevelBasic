using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Permite asignar las líneas para permitir habilitar el TextWriter

namespace CreateDocsTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter texto = new StreamWriter("prueba.txt"); //Permite crear un archivo de texto en blanco
            texto.WriteLine("Hello World; my name is Jesús"); //Crea una línea de texto en el documento TXT
            texto.Close(); //Termina el uso del documento TXT

        }
    }
}
