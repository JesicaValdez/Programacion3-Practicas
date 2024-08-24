using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato();
            gato1.nombre = "Tom";

            Perro perro1 = new Perro();
            perro1.nombre = "Pluto";

            List<Flyable> animalesVoladores = new List<Flyable>();
            animalesVoladores.Add(new Aguila());
            animalesVoladores.Add(new Canario());

            foreach (Flyable animal in animalesVoladores)
            {
                animal.volar();
            }

            Console.ReadKey();
        }
    }
}
