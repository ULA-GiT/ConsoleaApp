﻿using System;
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
            var p = new Persona();
            p.Nombre = "Rubén";
            p.Apellido = "Spagnuolo";
            Console.WriteLine ("{0}, {1}",p.Apellido, p.Nombre);
            Console.ReadKey(true);
            Console.WriteLine("Pulse cualquier tecla para terminar...");
        }
    }
}