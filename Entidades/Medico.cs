using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Medico : Persona
    {
       
        EEspecialidades especialidad;

        public Medico(string nombre, string apellido, int dni, EEspecialidades especialidad):base(nombre,apellido,dni)
        {
           
            this.especialidad = especialidad;

        }

    

        public static bool operator +(Medico[] medicos, Medico medico)
        {

            //recorro buscando libres
            for (int i = 0; i < medicos.Length; i++)
            {
                if (medicos[i] == null)
                {
                    medicos[i] = medico;
                    return true;
                }
            }

            //si no encontre libres agrego un lugar
            Array.Resize<Medico>(ref medicos, medicos.Length  + 1);

            medicos[medicos.Length - 1] = medico;
            return true;

        }

    }
}
