using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona   // la vamos a usar como clase base 
    {
        protected string nombre; // es privado para clases externas a la relacion de herencia
        protected string apellido;
        protected int dni;

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
        }

        public int Dni
        {
            get
            {
                return dni;
            }
        }


        public string NombreYApellido()
        {
            return string.Format($"El nombre es {this.nombre} y el apellido es {this.apellido}  ");
        }



    }
}
