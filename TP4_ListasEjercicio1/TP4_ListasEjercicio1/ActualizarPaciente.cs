using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_ListasEjercicio1
{
    public partial class ActualizarPaciente : Form
    {
        public Nodo pacienteSeleccionado = null;
        public Form1 frm1 = null;

        public ActualizarPaciente()
        {
            InitializeComponent(); 
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
            this.Close();
            frm1.ArmarLista();
        }

        private void ActualizarLista()
        {
            pacienteSeleccionado.nombre = this.inputNombre.Text;
            pacienteSeleccionado.apellido = this.inputApellido.Text;
            pacienteSeleccionado.direccion = this.inputDireccion.Text;
            pacienteSeleccionado.telefono= this.inputTel.Text;
        }

        private void ActualizarPaciente_Load(object sender, EventArgs e)
        {
            if (pacienteSeleccionado != null)
            {
                labelCodigo.Text = "Codigo de Paciente: " + pacienteSeleccionado.codigo;
                ObtenerDatosPaciente();
            }
        }

        private void ObtenerDatosPaciente()
        {
            this.inputNombre.Text = pacienteSeleccionado.nombre;
            this.inputApellido.Text = pacienteSeleccionado.apellido;
            this.inputDireccion.Text = pacienteSeleccionado.direccion;
            this.inputTel.Text = pacienteSeleccionado.telefono;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
