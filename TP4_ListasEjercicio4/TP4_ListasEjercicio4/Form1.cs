using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Ejercicio 4: En el jardín hay torneo del juego el pato ñato. Para la inscripción del mismo 
 * se requiere saber el nombre, apellido, edad y DNI. 
 * Se va a llevar un registro sistémico: 
 *      a. Registrar de los chicos que participan del juego.
 *      b. Poder eliminar a los chicos que van perdiendo (en cualquier posición) 
 *      c. Actualizar los datos de los chicos (modificar algún dato) 
 *      d. Agregar después del seleccionado. 
 *      e. Mostrar Listado de los chicos.
 * Nota: Se requiere jugar en forma circular
 */

namespace TP4_ListasEjercicio4
{
    public partial class Form1 : Form
    {
        public ListaCircular lista = new ListaCircular();
        public Jugador jugadorSeleccionado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = this.inputNombre.Text;
                string apellido = this.inputApellido.Text;
                int edad = Convert.ToInt32(this.inputEdad.Text);
                int dni = Convert.ToInt32(this.inputDNI.Text);
                lista.AgregarNuevo(nombre, apellido, edad, dni);
                LimpiarInputs();
                LimpiarLista();
                ArmarLista(lista.jugadorInicial);
            }
            catch (Exception)
            {
                MessageBox.Show("Datos incorrectos, por favor ingreselos nuevamente.", "Error");
            }
        }

        private void LimpiarInputs()
        {
            this.inputNombre.Text = this.inputApellido.Text = this.inputEdad.Text = this.inputDNI.Text = "";
        }

        public void ArmarLista(Jugador jugador)
        {
            if (jugador != null)
            {
                this.listaJugadores.Items.Add(jugador);
                if (jugador.siguiente != lista.jugadorInicial)
                    ArmarLista(jugador.siguiente);
            }
        }

        public void LimpiarLista()
        {
            this.listaJugadores.Items.Clear();
        }

        private void listaJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            jugadorSeleccionado = (Jugador) this.listaJugadores.SelectedItem;
        }

        private void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (jugadorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un jugador a eliminar", "Error");
            } else
            {
                DialogResult resultado = MessageBox.Show($"Esta seguro que desea eliminar el jugador: {jugadorSeleccionado.nombre} ?",
                    "Advertencia", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    lista.EliminarSeleccionado(jugadorSeleccionado);
                    LimpiarInputs();
                    LimpiarLista();
                    LimpiarSeleccionado();
                    ArmarLista(lista.jugadorInicial);
                    MessageBox.Show("Jugador eliminado correctamente", "Eliminado");
                }
            }
        }

        public void LimpiarSeleccionado()
        {
            this.jugadorSeleccionado = null;
        }

        private void btnActualizarSeleccionado_Click(object sender, EventArgs e)
        {
            if (jugadorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un jugador para actualizarlo", "Error");
            }
            else
            {
                ActualizarJugador actualizar = new ActualizarJugador();
                actualizar.juegoFormulario = this;
                actualizar.jugadorSeleccionado = jugadorSeleccionado;
                actualizar.lista = lista;
                actualizar.Show();
            }
        }

        private void btnAgregarDespues_Click(object sender, EventArgs e)
        {
            if (jugadorSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un jugador para agregar despues", "Error");
            }
            else
            {
                try
                {
                    string nombre = this.inputNombre.Text;
                    string apellido = this.inputApellido.Text;
                    int edad = Convert.ToInt32(this.inputEdad.Text);
                    int dni = Convert.ToInt32(this.inputDNI.Text);
                    lista.AgregarDespues(nombre, apellido, edad, dni, jugadorSeleccionado);
                    LimpiarInputs();
                    LimpiarLista();
                    ArmarLista(lista.jugadorInicial);
                }
                catch (Exception)
                {
                    MessageBox.Show("Datos incorrectos, por favor ingreselos nuevamente.", "Error");
                }
            }
        }
    }
}
