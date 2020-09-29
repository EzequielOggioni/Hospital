using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente: Persona
    {
        #region Atributos
   
        List<Enfermedad> listaEnfermedades;
        List<EDolencias> dolencias;
        #endregion

        #region Propiedades
     

        public string Dolencias
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (EDolencias auxDolencia in dolencias)
                {
                    sb.AppendLine(auxDolencia.ToString());
                }
                return sb.ToString();
            }
        }

// <summary>
        /// Propiedad indexada para retornar un elemento en especifico.
        /// </summary>
        /// <param name="i"> indice que será buscado en la lista</param>
        /// <returns> Si existe un elemento en ese indice,lo retorna. Sino retorna null </returns>
        public Enfermedad this[int i]
        {
            get
            {
                if (listaEnfermedades.Count > i)
                    return listaEnfermedades[i];
                return null;
            }
        }

        #endregion

        #region Constructores
     
        public Paciente(string nombre, string apellido, int dni, List<EDolencias> dolencias):base(nombre,apellido,dni)
        {
            listaEnfermedades = new List<Enfermedad>();
            this.dolencias =  dolencias;
        }
      
        #endregion

        #region Metodos

        /// <summary>
        /// Retorna la lista entera de Enfermedades
        /// </summary>
        public List<Enfermedad> GetEnfermedades()
        {

            return listaEnfermedades;
        }


        public override string DatosDePersona()
        {
            return $"Paciente: {this.NombreYApellido()}";
        }

        public override string DatosDePersona(string titulo)
        {
            return string.Empty;
        }

        public override bool Enfermar
        {
            get
            {
                return this.dolencias.Count > 2;
            }           

        }


        public virtual double CalcularCosto()
        {
            return this.listaEnfermedades.Count * 259.66; 
        }

        //public new string Esperar(string tiempo)
        //{
        //    return $"Espero que haya traido algo para leer por {tiempo}";
        //}

        #endregion

    }
}
