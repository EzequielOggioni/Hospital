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
        ArrayList Enfermedadesdd;
                
        List<Paciente> paciente;
        Medico[] medicos;

        public FrmPrincipal()
        {
            InitializeComponent();
            medicos = new Medico[1];
            paciente = new List<Paciente>();
            Enfermedades = new ArrayList(5);




        }

        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmABMMedico frmABMMedico = new FrmABMMedico();
            if (frmABMMedico.ShowDialog() == DialogResult.OK)
            {
                if (medicos + frmABMMedico.MiMedico) {

                    MessageBox.Show(" Se Agregó correctamente "," Alta de Medico");
                }
            }
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?","Huyendo",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void frm_load(object sender, EventArgs e)
        {
            /*
            Stack<int> pruebaPila = new Stack<int>();
            pruebaPila.Push(5);
            pruebaPila.Push(6);
            pruebaPila.Push(8);

            MessageBox.Show(pruebaPila.Pop().ToString());

            */

            Queue<int> Cola = new Queue<int>();
            Cola.Enqueue(4);
            Cola.Enqueue(8);
            Cola.Enqueue(18);
            int valor =  Cola.Dequeue();





        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAbmPaciente frmPaciente = new FrmAbmPaciente();
            if (frmPaciente.ShowDialog() == DialogResult.OK)
            {
                paciente.Add(frmPaciente.MiPaciente); 
            }
        }
    }
}
