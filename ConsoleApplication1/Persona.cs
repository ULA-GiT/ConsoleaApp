using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Persona
    {
        public Persona(string n, string a)
        {
            this.Nombre = n;
            this.Apellido = a;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
