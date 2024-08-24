using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Botella
    {
        /*Botella: Capacidad, Color, Material
         CAPACIDAD MAXIMA: 1000 ml
         CANTIDAD ACTUAL : 0 ml
         METODO RECARGA: carga al 100 y devuelve la cantidad de ml que se cargaron. 50 de cada 100.
         */

        //Atributos o Miembros
        private int _capacidad;
        private string _color;
        private string _material;
        private int _cantActual;

        //constructor
        public Botella(string color, string material)
        {
            this._color = color;
            this._material = material;
            _capacidad = 1000;
            _cantActual = 0;
        }

        public Botella()
        {
            _capacidad = 0;
            _color = "";
            _material = "";
            _cantActual = 0;
        }

        //Propiedades o seudo-metodos
        public int Capacidad
        {
            get { return _capacidad; }
        }
        public int CantActual
        {
            get { return _cantActual; }
        }
        public string Color
        {
            get { return _color; }
        }
        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        //Metodos
        public float Recargar()
        {
            if (_cantActual > 0)
            {
                int diferencia = _capacidad - _cantActual;
                float monto = diferencia * 50 / 100;
                _cantActual += diferencia;
                return monto;
            }
        
            _cantActual = 1000;
            return 50;
        }
    }
}
