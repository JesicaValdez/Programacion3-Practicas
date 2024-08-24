using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre

        //constructor
        public Persona()
        {
            _edad = 0;
            _sueldo = 0;
            _nombre = "";
        }

        public Persona(int e, float s, string n)
        {
            _edad = e;
            _sueldo = s;
            _nombre = n;
        }
       
        //Atributos o Miembros
        private int _edad;
        private float _sueldo;
        private string _nombre;

        //Metodos
        public void setEdad(int e)
        {
            _edad = e;
        }
        public int getEdad()
        {
            return _edad;
        }

        public void setSueldo(float s)
        {
            _sueldo = s;
        }
        public float getSueldo()
        {
            return _sueldo;
        }

        public void setNombre(string n)
        {
            _nombre = n;
        }
        public string getNombre()
        {
            return _nombre;
        }



    }
}
