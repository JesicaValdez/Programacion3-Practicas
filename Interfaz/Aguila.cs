using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Aguila : AnimalSalvaje, Flyable
    {
        public void volar()
        {
            Console.WriteLine("El águila está volando");
        }

    }
}
