using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ejercicio 2 - Realice un sistema que permita el registro de alumnos de una institución que permita registrar, 
 * modificar, eliminar los mismos. 
 * Los datos de los alumnos son nombres, apellido, DNI, fecha de nacimiento, dirección y teléfono.
 * El sistema debe permitir:
 *      a. Registrar un nuevo alumno
 *      b. Eliminar alumno (en cualquier posición)
 *      c. Actualizar alumno (modificar algún dato)
 *      d. Agregar después del seleccionado
 *      e. Agregar antes del seleccionado
 *      f. Mostrar Listado de los alumnos actuales */

namespace TP4_ListasEjercicio2
{
    public partial class Form1 : Form
    {
        ListaAlumnos lista = new ListaAlumnos();
        Nodo nodoSeleccionado;
        Dictionary<string, string> datosAlumno = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarNuevo_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                CargarDatosAlumno();
                lista.AgregarAlumno(datosAlumno);
                LimpiarLista();
                GenerarLista(lista.nodoInicial);
                LimpiarInputs();
            }
        }

        /*
         * Validar que todos los campos sean cargados
         */
        private bool ValidarDatos()
        {
            bool validar = (
                this.inputNombre.Text    != "" &&
                this.inputApellido.Text  != "" &&
                this.inputDNI.Text       != "" &&
                this.inputDireccion.Text != "" &&
                this.inputTel.Text       != "" &&
                this.inputFecha.Text     != ""
            );

            if (!validar)
                MessageBox.Show("Datos invalidos. Complete todos los campos.", "Error");
            
            return validar;
        }

        /*
        * Almacenar los datos cargados del usuario en un diccionario clave -> valor
        */
        private void CargarDatosAlumno()
        {
            datosAlumno.Add("nombre", this.inputNombre.Text);
            datosAlumno.Add("apellido", this.inputApellido.Text);
            datosAlumno.Add("dni", this.inputDNI.Text);
            datosAlumno.Add("direccion", this.inputDireccion.Text);
            datosAlumno.Add("tel", this.inputTel.Text);
            datosAlumno.Add("fechaNacimiento", this.inputFecha.Text);
        }
        private void LimpiarLista()
        {
            this.listaAlumnos.Items.Clear();
        }

        /*
         * Armar lista con el nodo inicial
         */
        private void GenerarLista(Nodo nodoInicial)
        {

            if (nodoInicial != null)
            {
                this.listaAlumnos.Items.Add(nodoInicial);
                if (nodoInicial.siguiente != null)
                    GenerarLista(nodoInicial.siguiente);
            }
        }

        private void LimpiarInputs()
        {
            this.inputNombre.Text    = "";
            this.inputApellido.Text  = "";
            this.inputDNI.Text       = "";
            this.inputDireccion.Text = "";
            this.inputTel.Text       = "";
            this.datosAlumno.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarSeleccionado())
                lista.EliminarAlumno(nodoSeleccionado);
        }

        private bool ValidarSeleccionado()
        {
            if (nodoSeleccionado != null)
                return true;

            MessageBox.Show("Debe seleccionar un alumno a eliminar", "Alumno no seleccionado");
            return false;
        }

        private void listaAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo) listaAlumnos.SelectedItem;
        }
    }
}
