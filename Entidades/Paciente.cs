using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    {
        #region Atributos

        string nombre;
        string apellido;
        int dni;
        List<Enfermedad> listaEnfermedades;
        List<EDolencias> dolencias;
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; }

        public string Apellido { get => apellido; }

        public int Dni { get => dni; }

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

        /// <summary>
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
        private Paciente()
        {
            listaEnfermedades = new List<Enfermedad>();
        }

        public Paciente(string nombre, string apellido, int dni, List<EDolencias> dolencias)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.dolencias = dolencias;

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
        #endregion

    }
}
