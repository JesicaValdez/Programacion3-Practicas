using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Persona accedida desde el programa con Metodos:
            Persona p1 = new Persona();
            p1.setEdad(20);
            p1.setSueldo(2000);
            p1.setNombre("Juan");

            Console.WriteLine("La edad de Juan es: " + p1.getEdad());
            Console.WriteLine("El sueldo de Juan es: " + p1.getSueldo());

            //Botella accedida desde el programa con Propiedades:
            Botella b1 = new Botella();
            b1.Material = "Plastico";

            Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad);
            Console.WriteLine("El color de la botella es: " + b1.Color);
            Console.WriteLine("El material de la botella es: " + b1.Material);
        
            //Perro accedida desde el programa con Propiedades:
            Perro perro1 = new Perro();
            perro1.Raza = "Pastor Aleman";
            perro1.Edad = 5;
            perro1.Nombre = "Firulais";

            Console.WriteLine("La raza del perro es: " + perro1.Raza);
            Console.WriteLine("La edad del perro es: " + perro1.Edad);
            Console.WriteLine("El nombre del perro es: " + perro1.Nombre);
        
            //Articulo accedida desde el programa con Propiedades:
            Articulo a1 = new Articulo();
            a1.Codigo = 1;
            a1.Descripcion = "Laptop";
            a1.Precio = 1000;

            Console.WriteLine("El codigo del articulo es: " + a1.Codigo);
            Console.WriteLine("La descripcion del articulo es: " + a1.Descripcion);
            Console.WriteLine("El precio del articulo es: " + a1.Precio);
        
            //Venta accedida desde el programa con Propiedades:
            Venta v1 = new Venta();
            v1.Fecha = DateTime.Now;
            v1.CodigoArticulo = 1;
            v1.Cantidad = 2;
            v1.Total = 1000;
            v1.Cliente = "Laura";

            Console.WriteLine("La fecha de la venta es: " + v1.Fecha);
            Console.WriteLine("El codigo del articulo es: " + v1.CodigoArticulo);
            Console.WriteLine("La cantidad de articulos es: " + v1.Cantidad);
            Console.WriteLine("El total de la venta es: " + v1.Total);
            Console.WriteLine("El cliente es: " + v1.Cliente);


            //Recargar Botella
            Botella b2 = new Botella("Transparente", "Plástico");

            Console.WriteLine("La capacidad de la botella es: " + b2.Capacidad);
            Console.WriteLine("El color de la botella es: " + b2.Color);
            Console.WriteLine("El material de la botella es: " + b2.Material);
            Console.WriteLine("La cantidad actual de la botella es: " + b2.CantActual);

            b2.Recargar();
            Console.WriteLine("Se recargaron: " + b2.Recargar() + " ml");
            Console.WriteLine("Luego de recargar la botella la cantidad actual es: " + b2.CantActual);

            Console.ReadKey();
        }
    }
}
