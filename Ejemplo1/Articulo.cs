using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Articulo
    {
        //Articulo: Codigo, Descripcion, Precio

        //constructor
        public Articulo()
        {
            codigo = 0;
            descripcion = "";
            precio = 0;
        }
        
        //Atributos o Miembros
        private int codigo;
        private string descripcion;
        private float precio;

        //Propiedades o seudo-metodos
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
