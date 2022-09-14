using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_ListasEjercicio2
{
    public partial class ActualizarAlumno : Form
    {
        public Nodo alumnoSeleccionado;
        public Form1 frm1;
        public ActualizarAlumno()
        {
            InitializeComponent();
        }

        private void ActualizarAlumno_Load(object sender, EventArgs e)
        {
            this.labelActualizar.Text += alumnoSeleccionado.nombre + " " + alumnoSeleccionado.apellido;
            this.inputNombre.Text = alumnoSeleccionado.nombre;
            this.inputApellido.Text = alumnoSeleccionado.apellido;
            this.inputDNI.Text = Convert.ToString(alumnoSeleccionado.dni);
            this.inputDireccion.Text = alumnoSeleccionado.direccion;
            this.inputTel.Text = alumnoSeleccionado.telefono;
            this.inputFecha.Text = alumnoSeleccionado.fechaNacimiento;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                alumnoSeleccionado.nombre = this.inputNombre.Text;
                alumnoSeleccionado.apellido = this.inputApellido.Text;
                alumnoSeleccionado.dni = Convert.ToInt32(this.inputDNI.Text);
                alumnoSeleccionado.direccion = this.inputDireccion.Text;
                alumnoSeleccionado.telefono = this.inputTel.Text;
                alumnoSeleccionado.fechaNacimiento = this.inputFecha.Text;
                this.frm1.LimpiarLista();
                this.frm1.GenerarLista(frm1.lista.nodoInicial);
                this.Close();
            }
        }

        private bool ValidarDatos()
        {
            bool validar = (
                this.inputNombre.Text != "" &&
                this.inputApellido.Text != "" &&
                this.inputDNI.Text != "" &&
                this.inputDireccion.Text != "" &&
                this.inputTel.Text != "" &&
                this.inputFecha.Text != ""
            );

            if (!validar)
                MessageBox.Show("Datos invalidos. Complete todos los campos.", "Error");

            return validar;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
