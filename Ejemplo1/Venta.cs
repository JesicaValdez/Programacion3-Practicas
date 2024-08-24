using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Venta
    {
        //Venta: Fecha, Código Articulo, Cantidad, Total, Cliente

        //constructor
        public Venta()
        {
            _fecha = DateTime.Now;
            _codigoArticulo = 0;
            _cantidad = 0;
            _total = 0;
            _cliente = "";
        }
        
        //Atributos o Miembros
        private DateTime _fecha;
        private int _codigoArticulo;
        private int _cantidad;
        private float _total;
        private string _cliente;
       
        //Propiedades o seudo-metodos
        public DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public int CodigoArticulo
        {
            get { return _codigoArticulo; }
            set { _codigoArticulo = value; }
        }
        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }
        public string Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

    }
}
