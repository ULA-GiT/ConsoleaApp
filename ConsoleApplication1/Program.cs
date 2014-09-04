using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo!");
            var p = new Persona("Rubén", "Spagnuolo");
            Console.WriteLine ("{0}, {1}",p.Apellido, p.Nombre);
            Console.WriteLine("Pulse cualquier tecla para terminar...");
            Console.ReadKey(true);         
        }
    }
}