using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Perro
    {
        //Perro: Raza, Edad, Nombre

        //constructor 
        public Perro()
        {
            _raza = "";
            _edad = 0;
            _nombre = "";
        }

        public Perro(string raza, int edad, string nombre)
        {
            this._raza = raza;
            this._edad = edad;
            this._nombre = nombre;
        }



        //Atributos o Miembros
        private string _raza;
        private int _edad;
        private string _nombre;

        //Propiedades o seudo-metodos
        public string Raza
        {
            get { return _raza; }
            set { _raza = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
