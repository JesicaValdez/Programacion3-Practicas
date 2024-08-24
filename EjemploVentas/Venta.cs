using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentas
{
    internal class Venta
    {
        /*
         - Fecha
         - Código Cliente (1 a 100)
         - Código Artículo
         - Cantidad
         - Importe
         - Total
         
         */

        //constructor
        public Venta()
        {
            Fecha = DateTime.Now;
            CodigoCliente = 0;
            CodigoArticulo = 0;
            Cantidad = 0;
            Importe = 0;
            Total = 0;
        }

        public DateTime Fecha { get; set; }
        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
        public float Importe { get; set; }
        public float Total { get; set; }
        
    }
}
