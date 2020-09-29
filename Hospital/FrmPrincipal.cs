using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FrmPrincipal : Form
    {

        List<Paciente> pacientes;
        List<Persona> listaPersonasDelHospital; 
        Medico[] medicos;

        public FrmPrincipal()
        {
            InitializeComponent();
            medicos = new Medico[1];
            pacientes = new List<Paciente>();
            listaPersonasDelHospital = new List<Persona>();
        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMMedico frmABMMedico = new FrmABMMedico();
            if (frmABMMedico.ShowDialog() == DialogResult.OK)
            {
                if (medicos + frmABMMedico.MiMedico)
                {

                    MessageBox.Show(" Se Agregó correctamente ", " Alta de Medico");
                }
            }

        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Huyendo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void CargarDatagridPacientes()
        {
            this.dtgvPacientes.DataSource = null;
            this.dtgvPacientes.DataSource = listaPersonasDelHospital;
            ConfiguracionDatagrid();
        }

        private void ConfiguracionDatagrid()
        {
              
         //   this.dtgvPacientes.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            this.dtgvPacientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void frm_load(object sender, EventArgs e)
        {
            CargaInicial();
            CargarDatagridPacientes();

            #region EjemploCodigoPila
            /*
           Stack<int> pruebaPila = new Stack<int>();
           pruebaPila.Push(5);
           pruebaPila.Push(6);
           pruebaPila.Push(8);

           MessageBox.Show(pruebaPila.Pop().ToString());

           */
            #endregion

            #region EjemploCodigoCola

            //Queue<int> Cola = new Queue<int>();
            //Cola.Enqueue(4);
            //Cola.Enqueue(8);
            //Cola.Enqueue(18);
            //int valor = Cola.Dequeue();

            #endregion

        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMPaciente frmPaciente = new FrmABMPaciente();
            if (frmPaciente.ShowDialog() == DialogResult.OK)
            {
                pacientes.Add(frmPaciente.MiPaciente);
            }
        }

        private void CargaInicial()
        {

            //forma larga de crear una LISTA a partir de  un array 

            listaPersonasDelHospital.Add(new Paciente("Romeo","Gatusso", 122223, new List<EDolencias>(new EDolencias[] { EDolencias.DolorExtremidades})));

            listaPersonasDelHospital.Add(new Paciente("Pepe", "Peposo", 123123, new List<EDolencias>(new EDolencias[] { EDolencias.DolorCabeza, EDolencias.Fiebre, EDolencias.Tos })));

            listaPersonasDelHospital.Add(new Medico("Eze", "Fede", 33333, EEspecialidades.Cardiologia));

            Paciente miPaciente;
            Medico miMedico;

            foreach (Persona auxPersona in listaPersonasDelHospital) 
            {
                //if (auxPersona is Paciente)
                //{
                //    miPaciente = (Paciente)auxPersona;
                //}
                //else
                //{
                //    miMedico = (Medico)auxPersona;
                //}

                // Sugerido por Ezequiel
                //if(auxPersona.GetType() == typeof(Paciente))
                //{

                //}


                // SUGERIDO POR EZEQUIEL
                //if(auxPersona.GetType().ToString() == "Entidades.Paciente")
                //{

                //}

            }








            CargarDatagridPacientes();

        }

        private void btnHardcodearMásPacientes_Click(object sender, EventArgs e)
        {
            pacientes.Add(new Paciente("Carola", "Perrosa", 123123, new List<EDolencias>(new EDolencias[] {  EDolencias.Fiebre, EDolencias.Tos })));
            pacientes.Add(new Paciente("Jazmin", "Canina", 122223, new List<EDolencias>(new EDolencias[] { EDolencias.Tos,EDolencias.DolorExtremidades })));

            CargarDatagridPacientes();
        }

        private void mensajersMolestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Persona miPersona= new Paciente("Pepe", "Peposo", 123123, new List<EDolencias>(new EDolencias[] { EDolencias.DolorCabeza, EDolencias.Fiebre, EDolencias.Tos }));

            miPersona.Esperar("15");
            miPersona = new Medico("Eze", "Fede", 33333, EEspecialidades.Cardiologia);
            miPersona.Esperar("15");


            foreach (Persona persona in listaPersonasDelHospital)
            {
               MessageBox.Show( persona.DatosDePersona());
            }
        }

        private void mensajesMolestos2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Random random = new Random(DateTime.Now.Millisecond);

            foreach (Persona persona in listaPersonasDelHospital)
            {
                MessageBox.Show(persona.Esperar(random.Next(10,200).ToString()));
            }


            foreach (Persona persona in listaPersonasDelHospital)
            {
                if (persona is Paciente)
                    MessageBox.Show(((Paciente)persona).Esperar(random.Next(10, 200).ToString()));
                else
                    MessageBox.Show(((Medico)persona).Esperar(random.Next(10, 200).ToString()));
            }

        }
    }
}
