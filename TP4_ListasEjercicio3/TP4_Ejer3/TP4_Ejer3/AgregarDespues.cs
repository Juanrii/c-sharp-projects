using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Ejer3
{
    public partial class AgregarDespues : Form
    {
        public NodoCliente clienteSeleccionado;
        public int cantClientes;
        public CineForm cineForm;

        public AgregarDespues()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NodoCliente nuevoCliente = new NodoCliente();
                nuevoCliente.edad = Convert.ToInt32(this.inputEdad.Text);
                // Tomo el ultimo ID y le sumo uno
                nuevoCliente.id = cantClientes + 1;

                if (clienteSeleccionado != null)
                {
                    NodoCliente aux = clienteSeleccionado.siguiente;
                    clienteSeleccionado.siguiente = nuevoCliente;
                    nuevoCliente.siguiente = aux;
                    this.cineForm.ActualizarLista();
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos, vuelva a ingresarlos por favor.", "Datos invalidos");
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
