using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ejercicio 1 - Se tiene una lista de pacientes de un hospital y se desea realizar un sistema sobre registro de los mismos.
 Los datos de los pacientes son código, nombres, apellido, dirección y teléfono.
 El sistema debe permitir:
      a. Registrar un nuevo paciente
      b. Eliminar paciente (en cualquier posición)
      c. Actualizar Pacientes (modificar algún dato)
      d. Agregar después del seleccionado.
      e. Mostrar Listado */

namespace TP4_ListasEjercicio1
{
    public partial class Form1 : Form
    {
        ListaPacientes lista = new ListaPacientes();

        Nodo nodoSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaPacientes.Hide();
            btnOcultar.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = this.inputCodigo.Text;
            string nombre = this.inputNombre.Text;
            string apellido = this.inputApellido.Text;
            string direc = this.inputDireccion.Text;
            string tel = this.inputTel.Text;
            lista.AgregarAlPrinicipio(codigo, nombre, apellido, direc, tel);
            ArmarLista();
            Limpiar();
        }

        private void Limpiar()
        {
            this.inputCodigo.Clear();
            this.inputNombre.Clear();
            this.inputApellido.Clear();
            this.inputDireccion.Clear();
            this.inputTel.Clear();
        }

        private void ArmarLista()
        {
            this.listaPacientes.Items.Clear();
            Listar(lista.nodoInicial);
        }

        private void Listar(Nodo nodoInicial)
        {
            if (nodoInicial != null)
            {
                listaPacientes.Items.Add(nodoInicial);
                if (nodoInicial.siguiente != null)
                    Listar(nodoInicial.siguiente);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listaPacientes.Show();
            btnOcultar.Show();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            listaPacientes.Hide();
            btnOcultar.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Error");
            } 
            else
            {
                lista.EliminarPaciente(nodoSeleccionado);
                MessageBox.Show("El paciente fue eliminado", "Eliminado");
                ArmarLista();
            }

        }

        private void listaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            nodoSeleccionado = (Nodo) this.listaPacientes.SelectedItem;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (nodoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Error");
            }
            else
            {
                ActualizarPaciente actualizar = new ActualizarPaciente();
                this.Hide();
                actualizar.Show();
            }
        }
    }
}
