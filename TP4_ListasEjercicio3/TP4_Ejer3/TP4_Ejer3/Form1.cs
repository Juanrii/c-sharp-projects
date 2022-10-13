using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ejercicio 3 - Un cine pequeño nos propone hacer una aplicación para controlar 
 * las personas que ingresa al mismo, para los grandes estrenos de películas.
 * Unos conjuntos de personas esperaran para sacar una entrada, tendremos que calcular 
 * la entrada según la edad de la persona (mínimo 5 años).
 * Las edades de las personas se generan aleatoriamente entre 5 y 60 años.
 * Al final, deberemos mostrar la cantidad total recaudada. El número de personas de la lista 
 * se elige al azar entre 0 y 50. 
 * Además, se debe permitir: 
 *      a. Llevar un registrar de las nuevas personas que ingresan a la lista 
 *      b. Poder eliminar a la persona que se va de la lista (en cualquier posición) 
 *      c. Actualizar los datos de la persona (modificar algún dato) 
 *      d. Mostrar Listado de las personas.
 *      e. Agregar después del seleccionado. */

namespace TP4_Ejer3
{
    public partial class CineForm : Form
    {

        ListaEnlazada lista = new ListaEnlazada();
        public NodoCliente clienteSeleccionado;
        public int cantClientes = 0;
        public CineForm()
        {
            InitializeComponent();
        }

        private void btnGenerarAleatorios_Click(object sender, EventArgs e)
        {
            this.listaPersonas.Items.Clear();
            lista.nodoInicial = null;

            Random rand = new Random();
            this.cantClientes = rand.Next(0, 51);
            Random edadRnd = new Random();
                
            for (int i = 1; i <= this.cantClientes; i++)
            {
                NodoCliente nuevoCliente = new NodoCliente();
                nuevoCliente.id = i;
                nuevoCliente.edad = edadRnd.Next(5, 61);
                lista.AgregarAlFinal(nuevoCliente);
                this.listaPersonas.Items.Add(nuevoCliente);
            }


            //lista.AgregarAleatorios();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente a eliminar", "Cliente no seleccionado");
            } 
            else
            {

                DialogResult opcion = MessageBox.Show($"Esta seguro que desea elimiar el cliente con ID: {clienteSeleccionado.id}?", 
                    "Aviso", MessageBoxButtons.YesNo);

                if (opcion == DialogResult.Yes)
                {
                    lista.EliminarSeleccionado(clienteSeleccionado);
                    this.listaPersonas.Items.Clear();
                    ArmarLista(lista.nodoInicial);
                    this.clienteSeleccionado = null;
                }
            }
        }

        private void ArmarLista(NodoCliente nodoInicial)
        {
            if (nodoInicial != null)
            {
                this.listaPersonas.Items.Add(nodoInicial);
                this.cantClientes++;
                ArmarLista(nodoInicial.siguiente);
            }
        }

        private void listaPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            clienteSeleccionado = (NodoCliente) this.listaPersonas.SelectedItem;
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para acualizar", "Cliente no seleccionado");
            }
            else
            {
                Actualizar actualizar = new Actualizar();
                actualizar.clienteSeleccionado = clienteSeleccionado;
                actualizar.cineForm = this;
                actualizar.Show();
            }
        }

        internal void ActualizarLista()
        {
            this.cantClientes = 0;
            this.listaPersonas.Items.Clear();
            ArmarLista(lista.nodoInicial);
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente para agregar despues", "Cliente no seleccionado");
            }
            else
            {
                AgregarDespues agregarDesp = new AgregarDespues();
                agregarDesp.clienteSeleccionado = this.clienteSeleccionado;
                agregarDesp.cantClientes = this.cantClientes;
                agregarDesp.cineForm = this;
                agregarDesp.Show();
            }
        }

        bool listaVisible = true;
        private void btnOcultarMostrarLsitado_Click(object sender, EventArgs e)
        {
            if (listaVisible)
            {
                this.btnOcultarMostrarLsitado.Text = "Mostrar Listado";
                this.listaPersonas.Hide();
            }
            else
            {
                this.btnOcultarMostrarLsitado.Text = "Ocultar Listado";
                this.listaPersonas.Show();
            }
            listaVisible = !listaVisible;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
