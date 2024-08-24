using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentas
{
    internal class Articulo
    {
        /*
         - Código Artículo (3 digitos no correlativos)
         - Precio
         - Código de Marca (1 a 10)
         */

        //constructor 
        public Articulo()
        {
            CodigoArticulo = 0;
            Precio = 0;
            CodMarca = 0;
        }

        public Articulo(int codigoArticulo, float precio, int codMarca)
        {
            CodigoArticulo = codigoArticulo;
            Precio = precio;
            CodMarca = codMarca;
          
        }

        //Propiedad con formato reducido
        public int CodigoArticulo { get; set; }

        public float Precio { get; set; }
        
        private int _codMarca;
        public int CodMarca
        {
            get { return _codMarca; }
            set 
            {
                if(value >= 1 && value <= 10)    
                _codMarca = value;
                
                else
                    _codMarca = -1;
            }
        }

        

    }
}
