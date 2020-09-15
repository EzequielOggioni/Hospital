using Entidades;
using System;
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
    public partial class FrmAbmPaciente : Form
    {
        private Paciente paciente;

        public Paciente MiPaciente
        {
            get { return paciente; }
            set { paciente = value; }
        }


        public FrmAbmPaciente()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.paciente = new Paciente("Pepe", "Peposo", 12312344, "Duele la muela");

            this.DialogResult = DialogResult.OK;
        }
    }
}
