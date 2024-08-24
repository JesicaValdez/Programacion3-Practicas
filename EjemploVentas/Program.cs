using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace EjemploVentas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Primer lote con 10 registros de productos, cada producto tiene:
              - Código Artículo (3 digitos no correlativos)
              - Precio
              - Código de Marca (1 a 10)
             * Segundo lote con las ventas de la semana. Cada venta tiene:
                - Fecha
                - Código Artículo
                - Cantidad
                - Código Cliente (1 a 100)
                - Total
             Este lote corta con Código de Cliente cero. 
             
             */

            //Primer lote
            Articulo[] articulos = new Articulo[10];
           
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Ingrese los datos del producto...");
                Console.WriteLine("Ingrese el código del artículo");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: $");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Código de Marca (1 a 10)");
                articulos[i].CodMarca = int.Parse(Console.ReadLine());
            }

            //Segundo lote
            Venta venta = new Venta();

            Console.WriteLine("Fecha: ");
            venta.Fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Código de Cliente (1 a 100)");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Codigo de Artículo: ");
            venta.CodigoArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            venta.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Importe del articulo: $");
            venta.Importe = float.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("INGRESE LA VENTA...");
                Console.WriteLine("Código de Cliente (1 a 100)");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
                
            }

            while(venta.CodigoCliente != 0)
            {
                Console.WriteLine("Fecha: ");
                venta.Fecha = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de Artículo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("Importe del articulo: $");
                venta.Importe = float.Parse(Console.ReadLine());

                //calculo el total de articulos
                venta.Total = venta.Cantidad * venta.Importe;


                Console.WriteLine("INGRESE LA VENTA...");
                Console.WriteLine("Código de Cliente (1 a 100)");
                venta.CodigoCliente = int.Parse(Console.ReadLine());


            }

            //Mostrar los datos de la venta
            Console.WriteLine("Fecha: " + venta.Fecha);
            Console.WriteLine("Código de Cliente: " + venta.CodigoCliente);
            Console.WriteLine("Código de Artículo: " + venta.CodigoArticulo);
            Console.WriteLine("Cantidad: " + venta.Cantidad);
            Console.WriteLine("Importe: $" + venta.Importe);
            Console.WriteLine("Total: $" + venta.Total);

        }
    }
}
