using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo1 = new Vehiculo();

            Camioneta camioneta1 = new Camioneta();
            camioneta1.color = "Rojo";
            camioneta1.marca = "Toyota";
            camioneta1.anio = 2020;
            camioneta1.motor = 4;
            camioneta1.capacidad = 1000;
            camioneta1.tipo = "Pickup";
            camioneta1.traccion = "4x4";

            Camioneta camioneta2 = new Camioneta();
            camioneta2.color = "Azul";
            camioneta2.marca = "Ford";
            camioneta2.anio = 2019;
            camioneta2.motor = 6;
            camioneta2.capacidad = 2000;
            camioneta2.tipo = "SUV";
            camioneta2.traccion = "4x2";

            Camioneta camioneta3 = new Camioneta();
            camioneta3.color = "Blanca";
            camioneta3.marca = "Chevrolet";
            camioneta3.anio = 2021;
            camioneta3.motor = 8;
            camioneta3.capacidad = 3000;
            camioneta3.tipo = "Camion";
            camioneta3.traccion = "6x4";

            List<Camioneta> camionetas = new List<Camioneta>();
            camionetas.Add(camioneta1);
            camionetas.Add(camioneta2);
            camionetas.Add(camioneta3);

            foreach (var camioneta in camionetas)
            {
                Console.WriteLine("Color: " + camioneta.color);
                Console.WriteLine("Marca: " + camioneta.marca);
                Console.WriteLine("Año: " + camioneta.anio);
                Console.WriteLine("Motor: " + camioneta.motor);
                Console.WriteLine("Capacidad: " + camioneta.capacidad);
                Console.WriteLine("Color: " + camioneta.tipo);
                Console.WriteLine("Color: " + camioneta.traccion);
                Console.WriteLine();
            }


            Console.ReadKey();
            
        }
    }
}
