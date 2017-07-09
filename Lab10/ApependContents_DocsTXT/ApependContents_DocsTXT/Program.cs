using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ApependContents_DocsTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este código es complemento de los proyectos anteriores ya que todos direccionan al primer proyecto
            StreamWriter texto = File.AppendText("prueba.txt");
            texto.WriteLine("Nuevo texto agregado");
            texto.Close();
        }
    }
}
