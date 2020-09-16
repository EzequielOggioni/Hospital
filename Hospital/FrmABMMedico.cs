using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace Hospital
{
    public partial class FrmABMMedico : Form
    {
               
        private Medico miMedico;

        public Medico MiMedico
        {
            get { return miMedico; }
            set { miMedico = value; }
        }

        public FrmABMMedico()
        {
            InitializeComponent(); 
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            int dni;
            if (int.TryParse(this.txtDni.Text, out dni) && this.cmbEspecialidad.SelectedIndex != -1)
            {
                miMedico = new Medico(this.txtNombre.Text,
                    this.txtApellido.Text, dni, 
                    (EEspecialidades)this.cmbEspecialidad.SelectedItem );
                
                this.DialogResult = DialogResult.OK;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtNombre.Text = " Aqui se setea el nombre";
            this.cmbEspecialidad.DataSource = Enum.GetValues(typeof(EEspecialidades));
        }


        private void txtNombre_Leave(object sender, EventArgs e)
        {
            //Quita espacios en blanco a izquierda y derecha
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();
            // Convierte todo el nombre a minusculas
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            //Convierto en mayuscula el primer caracter
            //Ana Maria
            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = Char.ToUpper(((TextBox)sender).Text[0]) + ((TextBox)sender).Text.Substring(1);

                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {
                    //"Ana maria"

                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(
                        //"Ana "
                        ((TextBox)sender).Text.Substring(0, posicion + 1),
                        //"M"
                        Char.ToUpper(((TextBox)sender).Text[posicion + 1]),
                        //"aria"
                        ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }

            }

        }
        
    }
}
