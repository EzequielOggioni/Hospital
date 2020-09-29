using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PacienteObraSocial:Paciente
    {
        public PacienteObraSocial(string nombre, string apellido, int dni, List<EDolencias> dolencias, EObraSocial OS, EPrepaga prepaga) :base(nombre, apellido, dni, dolencias)
        {
            this.obraSocial = OS;
            this.prepaga = prepaga;

        }
        private EObraSocial obraSocial;

        public EObraSocial ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        private EPrepaga prepaga;

        public EPrepaga Prepaga
        {
            get { return prepaga; }
            set { prepaga = value; }
        }


        public override double CalcularCosto()
        {
            double costo = base.CalcularCosto();
            costo -= costo * (int)this.ObraSocial / 100;
            costo -= costo * (int)this.prepaga;
            return costo;
        }

        public override string DatosDePersona()
        {
            return $"{base.DatosDePersona()} OS:{this.obraSocial}";
        }


    }
}
