using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    

    public abstract class Persona : SerVivo   // la vamos a usar como clase base 
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

        public virtual string Esperar(string tiempo)
        {            
            return $"Debe esperar {tiempo}";
        }


        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

  
        public string NombreYApellido()
        {
            return string.Format($"El nombre es {this.nombre} y el apellido es {this.apellido}  ");
        }

      
        public abstract string DatosDePersona();

        /// <summary>
        /// Este metodo muestra los datos con el respectivo titulo de la persona
        /// </summary>
        /// <param name="titulo"></param>
        /// <returns></returns>
        public abstract string DatosDePersona(string titulo);

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            sb.AppendLine(this.Apellido);
            sb.AppendLine(this.Dni.ToString());
            return sb.ToString();


        }

    }
}
