using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MiNombre = "Emmanuel";
            string mensaje = $"Hola yo soy {MiNombre}";
            string nuevoMensaje= mensaje.ToUpper() ;
            Console.WriteLine(nuevoMensaje);
            Console.ReadLine();
        }
    }
}
