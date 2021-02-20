using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Enfermedad
    {
        string nombre;
        EDolencias[] sintomas;

        private Enfermedad()
        {
            sintomas = new EDolencias[5];
        }
        public Enfermedad(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Enfermedad(string nombre, EDolencias[] sintomas) : this(nombre)
        {
            this.sintomas = sintomas;

        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
